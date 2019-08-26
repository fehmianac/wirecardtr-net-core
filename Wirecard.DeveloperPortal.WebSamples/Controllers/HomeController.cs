﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Mvc;
using SaleService;
using SendInformationSMSService;
using SubscriberService;
using Wirecard.DeveloperPortal.Core;
using Wirecard.DeveloperPortal.Core.Entity;
using Wirecard.DeveloperPortal.Core.Request;
using Wirecard.DeveloperPortal.Core.Response;
using Wirecard.DeveloperPortal.WebSamples.Models;

namespace Wirecard.DeveloperPortal.WebSamples.Controllers
{
    public class HomeController : BaseController
    {
        private SaleServiceSoapClient _proApiApiPlusService ;
        private SaleServiceSoapClient _getSaleResultMpayService;
        private SaleServiceSoapClient _getSaleResultOrderService;
        private SubscriberManagementServiceSoapClient _subscriberManagementService;
        private MSendSMSServiceSoapClient _sendSmsService;

        public ActionResult Index()
        {

            return View();
        }
        public ActionResult BasicApi()
        {
            return View();
        }

        public ActionResult ProApi()
        {
            return View();
        }
        /// <summary>
        /// Formdan gelen paymentTypeId ve productCategoryId değerleriyle ProApi servis çağrısı başlatılır.
        /// servis çağrısı sonucunda oluşan redirecturl adresine kullanıcı otomatik olarak yönlendirilir.
        /// </summary>
        /// <param name="paymentTypeId"></param>
        /// <param name="productCategoryId"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult ProApi(int paymentTypeId, int productCategoryId)
        {
            var url = Request.Path;
            _proApiApiPlusService = new SaleServiceSoapClient(SaleServiceSoapClient.EndpointConfiguration.SaleServiceSoap);
            #region Token
           SaleService.MAuthToken token = new SaleService.MAuthToken();
            token.UserCode = base.settings.UserCode;
            token.Pin = base.settings.Pin;
            #endregion
            #region MSaleProduct

            MSaleProduct product = new MSaleProduct();
            product.ProductId = 0;
            product.ProductCategory = productCategoryId;
            product.ProductDescription = "Telefon";
            product.Price = 0.01;
            product.Unit = 1;


            #endregion
            #region MSaleTicketInput
            MSaleTicketInput input = new MSaleTicketInput();
            input.MPAY = "01";
            input.Content = "TLFN01-Telefon";
            input.SendOrderResult = true;
            input.PaymentTypeId = paymentTypeId;
            input.ReceivedSMSObjectId = new Guid("00000000-0000-0000-0000-000000000000");
            input.ProductList = new[] { product };
            input.SendNotificationSMS = true;
            input.OnSuccessfulSMS = "basarili odeme yaptiniz";
            input.OnErrorSMS = "basarisiz odeme yaptiniz";
            input.Url = url;
            input.RequestGsmOperator = 0;
            input.RequestGsmType = 0;
            input.SuccessfulPageUrl = "http://localhost:32123/Home/Success";
            input.ErrorPageUrl = "http://localhost:32123/Home/Fail";
            input.Country = "";
            input.Currency = "";
            input.Extra = "";
            input.TurkcellServiceId = "";
            #endregion
            var saleWithTicketResult = _proApiApiPlusService.SaleWithTicketAsync(token, input).GetAwaiter().GetResult();
            return Redirect(saleWithTicketResult.RedirectUrl);
        }
        public ActionResult ApiPlus()
        {
            return View();
        }

        /// <summary>
        /// Formdan gelen değerlerle ApiPlus soap servis çağrısı başlatılır.
        /// Soap response xml mesajı ekranda gösterilir. 
        /// </summary>
        /// <param name="gsmNumber"></param>
        /// <param name="paymentTypeId"></param>
        /// <param name="productCategoryId"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult ApiPlus(string gsmNumber, int paymentTypeId, int productCategoryId)
        {
            var url = Request.Path;
            _proApiApiPlusService = new SaleServiceSoapClient(SaleServiceSoapClient.EndpointConfiguration.SaleServiceSoap);
            #region Token
            var token = new SaleService.MAuthToken();
            token.UserCode = base.settings.UserCode;
            token.Pin = base.settings.Pin;
            #endregion
            #region Product
            MSaleProduct product = new MSaleProduct();
            product.ProductId = 0;
            product.ProductCategory = productCategoryId;
            product.ProductDescription = "Telefon";
            product.Price = 0.01;
            product.Unit = 1;
            #endregion
            #region MSaleInput
            MSaleInput input = new MSaleInput();
            input.MPAY = "01";
            input.Gsm = gsmNumber;
            input.Content = "TLFN-Telefon";
            input.SendOrderResult = true;
            input.PaymentTypeId = paymentTypeId;
            input.Url = url;
            input.ReceivedSMSObjectId = new Guid("00000000-0000-0000-0000-000000000000");
            input.ProductList = new[] { product };
            input.SendNotificationSMS = true;
            input.OnSuccessfulSMS = "basarili odeme yaptiniz";
            input.OnErrorSMS = "basarisiz odeme yaptiniz";
            input.RequestGsmOperator = 0;
            input.RequestGsmType = 0;
            input.CustomerIpAddress = "127.0.0.1";
            input.Extra = "";
            input.TurkcellServiceId = "";
            #endregion
            var result = _proApiApiPlusService.SaleWithConfirmAsync(token, input).GetAwaiter().GetResult();
            return View(result);
        }

        //Abonelik Listeleme
        public ActionResult SelectSubscriber()
        {
            return View();
        }

        /// <summary>
        /// Bu servis daha önceden abone olan kullanıcıları telefon numaralarına ve çeşitli kriterlere göre aramamızı sağlar.
        /// </summary>
        /// <param name="gsm"></param>
        /// <param name="activeTypeId"></param>
        /// <param name="orderChannelId"></param>
        /// <param name="subscriberTypeId"></param>
        /// <param name="startDateMin"></param>
        /// <param name="startDateMax"></param>
        /// <param name="lastSuccessfulPaymentDateMin"></param>
        /// <param name="lastSuccessfulPaymentDateMax"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SelectSubscriber(string gsm, int activeTypeId, int orderChannelId, int subscriberTypeId, DateTime startDateMin, DateTime startDateMax, DateTime lastSuccessfulPaymentDateMin, DateTime lastSuccessfulPaymentDateMax)
        {
            _subscriberManagementService = new SubscriberManagementServiceSoapClient(SubscriberManagementServiceSoapClient.EndpointConfiguration.SubscriberManagementServiceSoap);

            #region Token

            SubscriberService.MAuthToken token = new SubscriberService.MAuthToken();
            token.UserCode = base.settings.UserCode;
            token.Pin = base.settings.Pin;

            #endregion

            #region MSelectSubscriberInput

            MSelectSubscriberInput input = new MSelectSubscriberInput();
            input.ProductId = 0;
            input.GSM = gsm;
            input.OrderChannelId = orderChannelId;
            input.Active = activeTypeId;
            input.SubscriberType = subscriberTypeId;
            input.StartDateMin = startDateMin;
            input.StartDateMax = startDateMax;
            input.LastSuccessfulPaymentDateMin = lastSuccessfulPaymentDateMin;
            input.LastSuccessfulPaymentDateMax = lastSuccessfulPaymentDateMax;
            #endregion

            var result = _subscriberManagementService.SelectSubscriberAsync(token, input).GetAwaiter().GetResult();
            return View(result);
        }
        //Abonelik Detay
        public ActionResult SelectSubscriberDetail()
        {
            return View();
        }
        /// <summary>
        /// Sms Aboneliği görüntülemek için abonelik numarası gereklidir.
        /// Web sayfasından girilen abonelik numarasına göre abonenin detayı görüntülenir.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SelectSubscriberDetail(Guid subscriberId)
        {
            _subscriberManagementService = new SubscriberManagementServiceSoapClient(SubscriberManagementServiceSoapClient.EndpointConfiguration.SubscriberManagementServiceSoap);
            SubscriberService.MAuthToken token = new SubscriberService.MAuthToken();
            token.UserCode = base.settings.UserCode;
            token.Pin = base.settings.Pin;
            var guid = new Guid(subscriberId.ToString());
            var response = _subscriberManagementService.SelectSubscriberDetailAsync(token, guid).GetAwaiter().GetResult();
            return View(response);
        }
        //Aboneliği Pasife Çekme
        public ActionResult DeactivateSubscriber()
        {
            return View();
        }
        /// <summary>
        /// Sms aboneliğini iptal etmek için abonelik numarası gereklidir.
        /// Web sayfasından girilen abonelik numarasına göre abonenin pasif duruma getirilmesi sağlanır.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult DeactivateSubscriber(Guid subscriberId)
        {
            _subscriberManagementService = new SubscriberManagementServiceSoapClient(SubscriberManagementServiceSoapClient.EndpointConfiguration.SubscriberManagementServiceSoap);
            SubscriberService.MAuthToken token = new SubscriberService.MAuthToken();
            token.UserCode = base.settings.UserCode;
            token.Pin = base.settings.Pin;
            var guid = new Guid(subscriberId.ToString());
            var response = _subscriberManagementService.DeactivateSubscriberAsync(token, guid).GetAwaiter().GetResult();
            return View(response);
        }

        public ActionResult ChangePriceBySubScriber()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ChangePriceBySubScriber(string subscriberId, string price)
        {
            var validFrom = DateTime.Now.AddDays(10).ToString("yyyyMMdd");
            var request = new ChangePriceBySubscriberRequest();
            request.ServiceType = "SubscriberManagementService";
            request.OperationType = "ChangePriceBySubscriber";
            request.SubscriberId = subscriberId;
            request.ValidFrom = validFrom;
            request.Price = price;
            request.Description = "Ödeme Güncelleme";

            #region Token
            request.Token = new Token();
            request.Token.UserCode = settings.UserCode;
            request.Token.Pin = settings.Pin;
            #endregion
            var response = ChangePriceBySubscriberRequest.Execute(request, settings);
            ServicesXmlResponse responseMessage = new ServicesXmlResponse();
            responseMessage.XmlResponse = response;
            return View(responseMessage);

        }
        public ActionResult SendInformationSmsService()
        {
            return View();
        }
        /// <summary>
        /// Web sayfasında gsm numarası ve gsm içeriği girilerek bilgi sms'i gönderimi servisinin çalıştırılması sağlanır.
        /// </summary>
        /// <param name="gsm"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SendInformationSmsService(string gsm, string content)
        {
            _sendSmsService = new MSendSMSServiceSoapClient(MSendSMSServiceSoapClient.EndpointConfiguration.MSendSMSServiceSoap);
            SendInformationSMSService.MAuthToken token = new SendInformationSMSService.MAuthToken();
            token.UserCode = base.settings.UserCode;
            token.Pin = base.settings.Pin;
            MSendSMSInput input = new MSendSMSInput();
            input.Gsm = gsm;
            input.Content = content;
            input.RequestGsmOperator = 0;
            var response = _sendSmsService.SendSMSAsync(token, input).GetAwaiter().GetResult();
            return View(response);
        }


        public ActionResult CCProxySale()
        {
            return View();
        }

        public ActionResult CCProxySale3D()
        {
            return View();
        }


        /// <summary>
        /// Ödeme Formu 3D secure ile ödeme yapılması için kullanılacak olan metodu temsil etmektedir.
        /// </summary>
        /// <param name="creditCardNo"></param>
        /// <param name="ownerName"></param>
        /// <param name="expireYear"></param>
        /// <param name="expireMonth"></param>
        /// <param name="cvv"></param>
        /// <param name="installmentCount"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult CCProxySale3D(string creditCardNo, string ownerName, int expireYear, int expireMonth, string cvv, int installmentCount,string currencyCode)
        {
            
             var request = new CCProxySale3DRequest();
            request.ServiceType = "CCProxy";
            request.OperationType = "Sale3DSEC";
            request.MPAY = "001";
            request.CurrencyCode = currencyCode;
            request.Port = "001";
            request.IPAddress = "127.0.0.1";
            request.PaymentContent = "Bilgisayar";
            request.InstallmentCount = installmentCount;
            request.Description = "Bilgisayar Ödemesi";
            request.ExtraParam = "";
            request.ErrorURL = "http://localhost:1794/Home/Fail";
            request.SuccessURL = "http://localhost:1794/Home/Success";

            #region Token
            request.Token = new Token();
            request.Token.UserCode = settings.UserCode;
            request.Token.Pin = settings.Pin;
            #endregion

            #region CreditCardInfo
            request.CreditCardInfo = new CreditCardInfo();
            request.CreditCardInfo.CreditCardNo = creditCardNo;
            request.CreditCardInfo.OwnerName = ownerName;
            request.CreditCardInfo.ExpireMonth = expireMonth;
            request.CreditCardInfo.ExpireYear = expireYear;
            request.CreditCardInfo.Cvv = cvv;
            request.CreditCardInfo.Price = 1;//0,01 TL
            #endregion

            #region CardTokenization

            request.CardTokenization = new CardTokenization();
            request.CardTokenization.RequestType = 0;
            request.CardTokenization.CustomerId = Guid.NewGuid().ToString();
            request.CardTokenization.ValidityPeriod = 0;
            request.CardTokenization.CCTokenId = string.Empty;

            #endregion
            #region CustomerInfo

            request.CustomerInfo = new CustomerInfo();
            request.CustomerInfo.CustomerName = "ahmet";
            request.CustomerInfo.CustomerSurname = "yılmaz";
            request.CustomerInfo.CustomerEmail = "ahmet.yilmaz@gmail.com";

            #endregion

            request.Language = "TR";
            var response = CCProxySale3DRequest.Execute(request, settings);
            ServicesXmlResponse responseMessage = new ServicesXmlResponse();
            responseMessage.XmlResponse = response;
            return View(responseMessage);
        }
        /// <summary>
        /// Ödeme formu, web sayfasından gelen bilgilerle birlikte başlatılır.
        /// Response cevabı sonucu oluşan xml cevabı ekranda gösterilir.
        /// </summary>
        /// <param name="creditCardNo"></param>
        /// <param name="ownerName"></param>
        /// <param name="expireYear"></param>
        /// <param name="expireMonth"></param>
        /// <param name="cvv"></param>
        /// <param name="installmentCount"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult CCProxySale(string creditCardNo, string ownerName, int expireYear, int expireMonth, string cvv, int installmentCount,string currencyCode)
        {
            var request = new CCProxySaleRequest();
            request.ServiceType = "CCProxy";
            request.OperationType = "Sale";
            request.MPAY = "001";
            request.CurrencyCode = currencyCode;
            request.Port = "001";
            request.IPAddress = "127.0.0.1";
            request.PaymentContent = "Bilgisayar";
            request.InstallmentCount = installmentCount;
            request.Description = "Bilgisayar Ödemesi";
            request.ExtraParam = "";

            #region Token
            request.Token = new Token();
            request.Token.UserCode = settings.UserCode;
            request.Token.Pin = settings.Pin;
            #endregion

            #region CreditCardInfo
            request.CreditCardInfo = new CreditCardInfo();
            request.CreditCardInfo.CreditCardNo = creditCardNo;
            request.CreditCardInfo.OwnerName = ownerName;
            request.CreditCardInfo.ExpireMonth = expireMonth;
            request.CreditCardInfo.ExpireYear = expireYear;
            request.CreditCardInfo.Cvv = cvv;
            request.CreditCardInfo.Price = 1;//0,01 TL
            #endregion
            #region CardTokenization

            request.CardTokenization = new CardTokenization();
            request.CardTokenization.RequestType = 0;
            request.CardTokenization.CustomerId = string.Empty;
            request.CardTokenization.ValidityPeriod = 0;
            request.CardTokenization.CCTokenId = string.Empty;

            #endregion
            #region CustomerInfo

            request.CustomerInfo = new CustomerInfo();
            request.CustomerInfo.CustomerName = "ahmet";
            request.CustomerInfo.CustomerSurname = "yılmaz";
            request.CustomerInfo.CustomerEmail = "ahmet.yilmaz@gmail.com";

            #endregion

            request.Language = "TR";
            var response = CCProxySaleRequest.Execute(request, settings);
            ServicesXmlResponse responseMessage = new ServicesXmlResponse();
            responseMessage.XmlResponse = response;
            return View(responseMessage);
        }

        public ActionResult WDTicketSale3DURLProxy()
        {

            return View();
        }
        /// <summary>
        /// 3D ile ödeme başlatmak için servis girdi parametrelerimizi PaymentFormRequest sınıfı ile ekliyoruz.
        /// 3D olmadan yapılan ödemeden tek farkı PaymentFormRequest sınıfı içerisinde OperationType alanı "Sale3DSURLProxy" olarak tanımlanması gerekiyor.
        /// Bu sınıf içerisinde bulunan değerleri  PaymentFormRequest.Execute(request, settings) kısmında https://www.wirecard.com.tr/SGate/Gate adresine post ediyoruz.
        /// işlem sonucunda oluşan xml metnini ve xml metni içerisinde bulunan RedirectUrl bilgisini paymentFormResponse sınıfına ekleyerek view sayfasına gönderiyoruz.
        /// View sayfası içerisinde ise ödemeyi tamamla butonuna basılırsa servis sonucunda oluşan RedirectUrl bilgisine yönlendirme yapılmış oluyor.
        /// </summary>
        /// <returns></returns>
        public ActionResult WDTicketSale3DURLProxyComplete()
        {
            WDTicketPaymentFormRequest request = new WDTicketPaymentFormRequest();
            request.ServiceType = "WDTicket";
            request.OperationType = "Sale3DSURLProxy";
            request.Price = 1;//0,01 TL
            request.MPAY = "";
            request.CurrencyCode = "TRY";
            request.ErrorURL = "http://localhost:1794/Home/Fail";
            request.SuccessURL = "http://localhost:1794/Home/Success";
            request.ExtraParam = "";
            request.PaymentContent = "Bilgisayar";
            request.Description = "BLGSYR01";
            request.PaymentTypeId = 1;
            request.InstallmentOptions = 0;
            request.Token = new Token();
            request.Token.Pin = base.settings.Pin;
            request.Token.UserCode = base.settings.UserCode;
            #region CustomerInfo

            request.CustomerInfo = new CustomerInfo();
            request.CustomerInfo.CustomerName = "ahmet";
            request.CustomerInfo.CustomerSurname = "yılmaz";
            request.CustomerInfo.CustomerEmail = "ahmet.yilmaz@gmail.com";

            #endregion

            request.Language = "TR";
            var response = WDTicketPaymentFormRequest.Execute(request, settings);

            var paymentFormResponse = new WDTicketPaymentFormResponse();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(response);
            XmlNode xmlNode = doc.SelectSingleNode("/Result/Item[@Key='RedirectUrl']");
            paymentFormResponse.RedirectUrl = xmlNode.Attributes["Value"].Value;
            paymentFormResponse.Response = response;
            return View(paymentFormResponse);
        }


        public ActionResult WDTicketSaleURLProxy()
        {
            return View();
        }

        /// <summary>
        /// //3D olmadan ödeme başlatmak için servis girdi parametrelerimizi PaymentFormRequest sınıfı ile ekliyoruz.
        /// 3D ile yapılan ödemeden tek farkı PaymentFormRequest sınıfı içerisinde OperationType alanı "SaleURLProxy" olarak tanımlanması gerekiyor.
        /// Bu sınıf içerisinde bulunan değerleri  PaymentFormRequest.Execute(request, settings) kısmında https://www.wirecard.com.tr/SGate/Gate adresine post ediyoruz.
        /// işlem sonucunda oluşan xml metnini ve xml metni içerisinde bulunan RedirectUrl bilgisini paymentFormResponse sınıfına ekleyerek view sayfasına gönderiyoruz.
        /// View sayfası içerisinde ise ödemeyi tamamla butonuna basılırsa servis sonucunda oluşan RedirectUrl bilgisine yönlendirme yapılmış oluyor.
        /// </summary>
        /// <returns></returns>
        public ActionResult WDTicketSaleUrlProxyComplete()
        {
            #region Request
            var request = new WDTicketPaymentFormRequest();
            request.ServiceType = "WDTicket";
            request.OperationType = "SaleURLProxy";
            request.Price = 1;//0,01 TL
            request.MPAY = "";
            request.CurrencyCode = "TRY";
            request.Description = "BLGSYR01";
            request.ErrorURL = "http://localhost:1794/Home/Fail";
            request.SuccessURL = "http://localhost:1794/Home/Success";
            request.ExtraParam = "";
            request.PaymentContent = "Bilgisayar";
            request.PaymentTypeId = 1;
            request.InstallmentOptions = 0;
            request.Token = new Token();
            request.Token.Pin = settings.Pin;
            request.Token.UserCode = settings.UserCode;
            #endregion
            #region CustomerInfo

            request.CustomerInfo = new CustomerInfo();
            request.CustomerInfo.CustomerName = "ahmet";
            request.CustomerInfo.CustomerSurname = "yılmaz";
            request.CustomerInfo.CustomerEmail = "ahmet.yilmaz@gmail.com";

            #endregion

            request.Language = "TR";
            #region Response
            var response = WDTicketPaymentFormRequest.Execute(request, settings);
            var paymentFormResponse = new WDTicketPaymentFormResponse();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(response);
            XmlNode xmlNode = doc.SelectSingleNode("/Result/Item[@Key='RedirectUrl']");
            paymentFormResponse.RedirectUrl = xmlNode.Attributes["Value"].Value;
            paymentFormResponse.Response = response;
            #endregion

            return View(paymentFormResponse);
        }

        public ActionResult BinQuery()
        {
            return View();
        }


        /// <summary>
        /// Yeni bir Pazaryeri oluşturulması için kullanılan metoddur.
        /// Pazaryeri oluşturulduktan sonra response değeri olarak SubPartnerId değeri bize gönderilir.
        /// </summary>
        /// <param name="subPartnerType"></param>
        /// <param name="name"></param>
        /// <param name="mobilePhoneNumber"></param>
        /// <param name="identityNumber"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult BinQuery(string bin)
        {
            BinQueryRequest request = new BinQueryRequest();
            request.ServiceType = "MerchantQueries";
            request.OperationType = "BinQueryOperation";
            request.BIN = bin;
           

            #region Token Bilgileri
            request.Token = new Token();
            request.Token.UserCode = settings.UserCode;
            request.Token.Pin = settings.Pin;
            #endregion

            var response = BinQueryRequest.Execute(request, settings);

            ServicesXmlResponse responseMessage = new ServicesXmlResponse();

            responseMessage.XmlResponse = response;
            return View(responseMessage);
        }

        //Market Place
        public ActionResult MarketPlaceAddSubPartner()
        {
            return View();
        }


        /// <summary>
        /// Yeni bir Pazaryeri oluşturulması için kullanılan metoddur.
        /// Pazaryeri oluşturulduktan sonra response değeri olarak SubPartnerId değeri bize gönderilir.
        /// </summary>
        /// <param name="subPartnerType"></param>
        /// <param name="name"></param>
        /// <param name="mobilePhoneNumber"></param>
        /// <param name="identityNumber"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult MarketPlaceAddSubPartner(SubPartnerTypeEnum subPartnerType, string name, string mobilePhoneNumber, string identityNumber, string email)
        {
            MarketPlaceAddOrUpdateRequest request = new MarketPlaceAddOrUpdateRequest();
            request.ServiceType = "CCMarketPlace";
            request.OperationType = "AddSubPartner";
            request.UniqueId = Guid.NewGuid().ToString().Replace("-", "");
            request.SubPartnerType = subPartnerType;
            request.Name = name;
            request.BranchName = name;

            #region Token Bilgileri
            request.Token = new Token();
            request.Token.UserCode = settings.UserCode;
            request.Token.Pin = settings.Pin;

            #endregion

            #region ContactInfo Bilgileri
            request.ContactInfo = new ContactInfo();
            request.ContactInfo.Country = "TR";
            request.ContactInfo.City = "34";
            request.ContactInfo.Address = "Gayrettepe Mh. Yıldız Posta Cd. D Plaza No:52 K:6 34349 Beşiktaş / İstanbul";
            request.ContactInfo.MobilePhone = mobilePhoneNumber;
            request.ContactInfo.BusinessPhone = "2121111111";
            request.ContactInfo.Email = email;
            request.ContactInfo.InvoiceEmail = email;
            #endregion
            #region FinancialInfo Bilgileri
            request.FinancialInfo = new FinancialInfo();
            request.FinancialInfo.IdentityNumber = identityNumber;
            request.FinancialInfo.TaxOffice = "İstanbul";
            request.FinancialInfo.TaxNumber = "11111111111";
            request.FinancialInfo.BankName = "0012";
            request.FinancialInfo.IBAN = "TR330006100519786457841326";


            #endregion

            #region AuthSignatory  Bilgileri
            request.AuthSignatory = new AuthSignatoryInfo();
            request.AuthSignatory.Name = "Ahmet";
            request.AuthSignatory.Surname = "Yaşar";
            request.AuthSignatory.BirthDate = DateTime.Now.ToString("yyyy/MM/dd");

            #endregion
            var response = MarketPlaceAddOrUpdateRequest.Execute(request, settings);

            ServicesXmlResponse responseMessage = new ServicesXmlResponse();

            responseMessage.XmlResponse = response;
            return View(responseMessage);
        }

        public ActionResult MarketPlaceCreateSubPartner()
        {
            return View();
        }
        /// <summary>
        /// Pazaryerinin güncellenmesi için kullanılır.
        /// Pazaryerinin güncellenmesi için pazaryeri oluşturulduğunda response değeri olarak verilen SubPartnerId değerinin gönderilmesi gerekmektedir.
        /// </summary>
        /// <param name="subPartnerType"></param>

        /// <returns></returns>
        [HttpPost]
        public ActionResult MarketPlaceCreateSubPartner(SubPartnerTypeWithIdEnum subPartnerType)
        {
            MarketPlaceCreateRequest request = new MarketPlaceCreateRequest();
            request.ServiceType = "WDTicket";
            request.OperationType = "CreateSPRegistrationURL";
            request.UniqueId = 5000;
            request.SubPartnerType = (int)subPartnerType;
            
            #region Token Bilgileri
            request.Token = new Token();
            request.Token.UserCode = settings.UserCode;
            request.Token.Pin = settings.Pin;

            #endregion

            var response = MarketPlaceCreateRequest.Execute(request, settings);

            ServicesXmlResponse responseMessage = new ServicesXmlResponse();
            responseMessage.XmlResponse = response;
            return View(responseMessage);
        }


        public ActionResult MarketPlaceUpdateSubPartner()
        {
            return View();
        }
        /// <summary>
        /// Pazaryerinin güncellenmesi için kullanılır.
        /// Pazaryerinin güncellenmesi için pazaryeri oluşturulduğunda response değeri olarak verilen SubPartnerId değerinin gönderilmesi gerekmektedir.
        /// </summary>
        /// <param name="subPartnerType"></param>
        /// <param name="name"></param>
        /// <param name="mobilePhoneNumber"></param>
        /// <param name="identityNumber"></param>
        /// <param name="subPartnerId"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult MarketPlaceUpdateSubPartner(SubPartnerTypeEnum subPartnerType, string name, string mobilePhoneNumber, string identityNumber, int subPartnerId, string email)
        {
            MarketPlaceAddOrUpdateRequest request = new MarketPlaceAddOrUpdateRequest();
            request.ServiceType = "CCMarketPlace";
            request.OperationType = "UpdateSubPartner";
            request.UniqueId = Guid.NewGuid().ToString();
            request.SubPartnerType = subPartnerType;
            request.Name = name;
            request.BranchName = name;
            request.SubPartnerId = subPartnerId;
            #region Token Bilgileri
            request.Token = new Token();
            request.Token.UserCode = settings.UserCode;
            request.Token.Pin = settings.Pin;

            #endregion

            #region ContactInfo Bilgileri
            request.ContactInfo = new ContactInfo();
            request.ContactInfo.Country = "TR";
            request.ContactInfo.City = "34";
            request.ContactInfo.Address = "Gayrettepe Mh. Yıldız Posta Cd. D Plaza No:52 K:6 34349 Beşiktaş / İstanbul";
            request.ContactInfo.MobilePhone = mobilePhoneNumber;
            request.ContactInfo.BusinessPhone = "2121111111";
            request.ContactInfo.Email = email;
            #endregion
            #region FinancialInfo Bilgileri
            request.FinancialInfo = new FinancialInfo();
            request.FinancialInfo.IdentityNumber = identityNumber;
            request.FinancialInfo.TaxOffice = "İstanbul";
            request.FinancialInfo.TaxNumber = "11111111111";
            request.FinancialInfo.BankName = "0012";
            request.FinancialInfo.IBAN = "TR330006100519786457841326";


            #endregion
            #region AuthSignatory  Bilgileri
            request.AuthSignatory = new AuthSignatoryInfo();
            request.AuthSignatory.Name = "Ahmet";
            request.AuthSignatory.Surname = "Yaşar";
            request.AuthSignatory.BirthDate = DateTime.Now.ToString("yyyy/MM/dd");


            #endregion
            var response = MarketPlaceAddOrUpdateRequest.Execute(request, settings);

            ServicesXmlResponse responseMessage = new ServicesXmlResponse();
            responseMessage.XmlResponse = response;
            return View(responseMessage);
        }



        public ActionResult MarketPlaceAddSubPartnerWithOnlineVerification()
        {
            return View();
        }


        /// <summary>
        /// Yeni bir Pazaryeri oluşturulması için kullanılan metoddur.
        /// Pazaryeri oluşturulduktan sonra response değeri olarak SubPartnerId değeri bize gönderilir.
        /// </summary>
        /// <param name="subPartnerType"></param>
        /// <param name="name"></param>
        /// <param name="mobilePhoneNumber"></param>
        /// <param name="identityNumber"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult MarketPlaceAddSubPartnerWithOnlineVerification(SubPartnerTypeEnum subPartnerType, string name, string mobilePhoneNumber, string identityNumber, string email)
        {
            MarketPlaceAddOrUpdateRequest request = new MarketPlaceAddOrUpdateRequest();
            request.ServiceType = "CCMarketPlace";
            request.OperationType = "AddSubPartner";
            request.UniqueId = Guid.NewGuid().ToString().Replace("-", "");
            request.SubPartnerType = subPartnerType;
            request.Name = name;
            request.BranchName = name;
            request.SuccessURL = "https://www.test.com/Success";
            request.ErrorURL = "https://www.test.com/Error";

            #region Token Bilgileri
            request.Token = new Token();
            request.Token.UserCode = settings.UserCode;
            request.Token.Pin = settings.Pin;

            #endregion

            #region ContactInfo Bilgileri
            request.ContactInfo = new ContactInfo();
            request.ContactInfo.Country = "TR";
            request.ContactInfo.City = "34";
            request.ContactInfo.Address = "Gayrettepe Mh. Yıldız Posta Cd. D Plaza No:52 K:6 34349 Beşiktaş / İstanbul";
            request.ContactInfo.MobilePhone = mobilePhoneNumber;
            request.ContactInfo.BusinessPhone = "2121111111";
            request.ContactInfo.Email = email;
            request.ContactInfo.InvoiceEmail = email;
            #endregion
            #region FinancialInfo Bilgileri
            request.FinancialInfo = new FinancialInfo();
            request.FinancialInfo.IdentityNumber = identityNumber;
            request.FinancialInfo.TaxOffice = "İstanbul";
            request.FinancialInfo.TaxNumber = "11111111111";
            request.FinancialInfo.BankName = "0012";
            request.FinancialInfo.IBAN = "TR330006100519786457841326";
            request.FinancialInfo.TradeRegisterNumber = "963018";
            request.FinancialInfo.TradeChamber = "İTO";

            #endregion

            #region AuthSignatory  Bilgileri
            request.AuthSignatory = new AuthSignatoryInfo();
            request.AuthSignatory.Name = "Ahmet";
            request.AuthSignatory.Surname = "Yaşar";
            request.AuthSignatory.BirthDate = DateTime.Now.ToString("yyyy/MM/dd");

            #endregion
            var response = MarketPlaceAddOrUpdateRequest.Execute(request, settings);

            ServicesXmlResponse responseMessage = new ServicesXmlResponse();

            responseMessage.XmlResponse = response;
            return View(responseMessage);
        }

        public ActionResult MarketPlaceUpdateSubPartnerWithOnlineVerification()
        {
            return View();
        }
        /// <summary>
        /// Pazaryerinin güncellenmesi için kullanılır.
        /// Pazaryerinin güncellenmesi için pazaryeri oluşturulduğunda response değeri olarak verilen SubPartnerId değerinin gönderilmesi gerekmektedir.
        /// </summary>
        /// <param name="subPartnerType"></param>
        /// <param name="name"></param>
        /// <param name="mobilePhoneNumber"></param>
        /// <param name="identityNumber"></param>
        /// <param name="subPartnerId"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult MarketPlaceUpdateSubPartnerWithOnlineVerification(SubPartnerTypeEnum subPartnerType, string name, string mobilePhoneNumber, string identityNumber, int subPartnerId, string email)
        {
            MarketPlaceAddOrUpdateRequest request = new MarketPlaceAddOrUpdateRequest();
            request.ServiceType = "CCMarketPlace";
            request.OperationType = "UpdateSubPartner";
            request.UniqueId = Guid.NewGuid().ToString();
            request.SubPartnerType = subPartnerType;
            request.Name = name;
            request.BranchName = name;
            request.SubPartnerId = subPartnerId;
            #region Token Bilgileri
            request.Token = new Token();
            request.Token.UserCode = settings.UserCode;
            request.Token.Pin = settings.Pin;

            #endregion

            #region ContactInfo Bilgileri
            request.ContactInfo = new ContactInfo();
            request.ContactInfo.Country = "TR";
            request.ContactInfo.City = "34";
            request.ContactInfo.Address = "Gayrettepe Mh. Yıldız Posta Cd. D Plaza No:52 K:6 34349 Beşiktaş / İstanbul";
            request.ContactInfo.MobilePhone = mobilePhoneNumber;
            request.ContactInfo.BusinessPhone = "2121111111";
            request.ContactInfo.Email = email;
            #endregion
            #region FinancialInfo Bilgileri
            request.FinancialInfo = new FinancialInfo();
            request.FinancialInfo.IdentityNumber = identityNumber;
            request.FinancialInfo.TaxOffice = "İstanbul";
            request.FinancialInfo.TaxNumber = "11111111111";
            request.FinancialInfo.BankName = "0012";
            request.FinancialInfo.IBAN = "TR330006100519786457841326";
            request.FinancialInfo.TradeRegisterNumber = "963018";
            request.FinancialInfo.TradeChamber = "İTO";

            #endregion
            #region AuthSignatory  Bilgileri
            request.AuthSignatory = new AuthSignatoryInfo();
            request.AuthSignatory.Name = "Ahmet";
            request.AuthSignatory.Surname = "Yaşar";
            request.AuthSignatory.BirthDate = DateTime.Now.ToString("yyyy/MM/dd");


            #endregion
            var response = MarketPlaceAddOrUpdateRequest.Execute(request, settings);

            ServicesXmlResponse responseMessage = new ServicesXmlResponse();
            responseMessage.XmlResponse = response;
            return View(responseMessage);
        }





        public ActionResult MarketPlaceDeactiveSubPartner()
        {
            return View();
        }
        /// <summary>
        /// pazaryerinin pasif hale getirilmesi için kullanılır.
        /// pazaryeri oluşturulurken gönderilen uniqueId değeri parametre olarak gönderilmesi gerekmektedir.
        /// </summary>
        /// <param name="uniqueId"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult MarketPlaceDeactiveSubPartner(string uniqueId)
        {
            MarketPlaceDeactiveRequest request = new MarketPlaceDeactiveRequest();
            request.ServiceType = "CCMarketPlace";
            request.OperationType = "DeactivateSubPartner";
            request.UniqueId = uniqueId;
            #region Token
            request.Token = new Token();
            request.Token.UserCode = settings.UserCode;
            request.Token.Pin = settings.Pin;
            var response = MarketPlaceDeactiveRequest.Execute(request, settings);

            ServicesXmlResponse responseMessage = new ServicesXmlResponse();
            responseMessage.XmlResponse = response;
            #endregion
            return View(responseMessage);
        }

        public ActionResult MarketPlaceSale3DSec()
        {
            return View();
        }
        /// <summary>
        /// Pazaryeri 3D secure ile ödeme  servisini başlatmak için parametrelerimizi sınıfımıza ekliyoruz.
        /// Hazırladığımız sınıfımızı https://www.wirecard.com.tr/SGate/Gate adresine post ediyoruz.
        /// işlem sonucunda oluşan xml sonucunu ekranda gösteriyoruz.
        /// </summary>
        /// <param name="creditCardNo"></param>
        /// <param name="ownerName"></param>
        /// <param name="expireYear"></param>
        /// <param name="expireMonth"></param>
        /// <param name="cvv"></param>
        /// <param name="installmentCount"></param>
        /// <param name="subPartnerId"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult MarketPlaceSale3DSec(string creditCardNo, string ownerName, int expireYear, int expireMonth, string cvv, int installmentCount, int subPartnerId,string currencyCode)
        {
            MarketPlaceSale3DSecOrMpSaleRequest request = new MarketPlaceSale3DSecOrMpSaleRequest();
            request.ServiceType = "CCMarketPlace";
            request.OperationType = "Sale3DSEC";
            request.MPAY = "";
            request.CurrencyCode = currencyCode;
            request.IPAddress = "195.168.1.4";
            request.Port = "123";
            request.Description = "Bilgisayar";
            request.InstallmentCount = installmentCount;
            request.CommissionRate = 100; //komisyon oranı 1. 100 ile çarpılıp gönderiliyor
            request.ExtraParam = "";
            request.PaymentContent = "BLGSYR01";
            request.SubPartnerId = subPartnerId;
            request.ErrorURL = "http://localhost:1794/Home/Fail";
            request.SuccessURL = "http://localhost:1794/Home/Success";

            #region Token
            request.Token = new Token();
            request.Token.UserCode = settings.UserCode;
            request.Token.Pin = settings.Pin;
            #endregion



            #region CreditCardInfo
            request.CreditCardInfo = new CreditCardInfo();
            request.CreditCardInfo.CreditCardNo = creditCardNo;
            request.CreditCardInfo.OwnerName = ownerName;
            request.CreditCardInfo.ExpireYear = expireYear;
            request.CreditCardInfo.ExpireMonth = expireMonth;
            request.CreditCardInfo.Cvv = cvv;
            request.CreditCardInfo.Price = 1;//0,01 TL
            #endregion

            #region CardTokenization

            request.CardTokenization = new CardTokenization();
            request.CardTokenization.RequestType = 0;
            request.CardTokenization.CustomerId = Guid.NewGuid().ToString();
            request.CardTokenization.ValidityPeriod = 0;
            request.CardTokenization.CCTokenId = string.Empty;

            #endregion
            #region CustomerInfo

            request.CustomerInfo = new CustomerInfo();
            request.CustomerInfo.CustomerName = "ahmet";
            request.CustomerInfo.CustomerSurname = "yılmaz";
            request.CustomerInfo.CustomerEmail = "ahmet.yilmaz@gmail.com";

            #endregion

            request.Language = "TR";
            var response = MarketPlaceSale3DSecOrMpSaleRequest.Execute(request, settings);
            ServicesXmlResponse responseMessage = new ServicesXmlResponse();
            responseMessage.XmlResponse = response;
            return View(responseMessage);
        }

        public ActionResult MarketPlaceMPSale()
        {
            return View();
        }
        /// <summary>
        // Pazaryeri 3D secure olmadan ödeme  servisini başlatmak için parametrelerimizi sınıfımıza ekliyoruz.
        /// Hazırladığımız sınıfımızı https://www.wirecard.com.tr/SGate/Gate adresine post ediyoruz.
        /// işlem sonucunda oluşan xml sonucunu ekranda gösteriyoruz.
        /// </summary>
        /// <param name="creditCardNo"></param>
        /// <param name="ownerName"></param>
        /// <param name="expireYear"></param>
        /// <param name="expireMonth"></param>
        /// <param name="cvv"></param>
        /// <param name="installmentCount"></param>
        /// <param name="subPartnerId"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult MarketPlaceMPSale(string creditCardNo, string ownerName, int expireYear, int expireMonth, string cvv, int installmentCount, int subPartnerId,string currencyCode)
        {
            MarketPlaceSale3DSecOrMpSaleRequest request = new MarketPlaceSale3DSecOrMpSaleRequest();
            request.ServiceType = "CCMarketPlace";
            request.OperationType = "MPSale";
            request.Price = 1; //0,01 TL
            request.MPAY = "01";
            request.CurrencyCode = currencyCode;
            request.IPAddress = "127.0.0.1";
            request.Port = "123";
            request.Description = "Bilgisayar";
            request.InstallmentCount = installmentCount;
            request.CommissionRate = 1; //komisyon oranı 1. 100 ile çarpılıp gönderiliyor
            request.ExtraParam = "";
            request.PaymentContent = "BLGSYR01";
            request.SubPartnerId = subPartnerId;
            request.ErrorURL = "http://localhost:1794/Home/Fail";
            request.SuccessURL = "http://localhost:1794/Home/Success";


            #region Token
            request.Token = new Token();
            request.Token.UserCode = settings.UserCode;
            request.Token.Pin = settings.Pin;
            #endregion

            #region CreditCardInfo
            request.CreditCardInfo = new CreditCardInfo();
            request.CreditCardInfo.CreditCardNo = creditCardNo;
            request.CreditCardInfo.OwnerName = ownerName;
            request.CreditCardInfo.ExpireYear = expireYear;
            request.CreditCardInfo.ExpireMonth = expireMonth;
            request.CreditCardInfo.Cvv = cvv;
            #endregion


            #region CardTokenization

            request.CardTokenization = new CardTokenization();
            request.CardTokenization.RequestType = 0;
            request.CardTokenization.CustomerId = Guid.NewGuid().ToString();
            request.CardTokenization.ValidityPeriod = 0;
            request.CardTokenization.CCTokenId = String.Empty;

            #endregion
            #region CustomerInfo

            request.CustomerInfo = new CustomerInfo();
            request.CustomerInfo.CustomerName = "ahmet";
            request.CustomerInfo.CustomerSurname = "yılmaz";
            request.CustomerInfo.CustomerEmail = "ahmet.yilmaz@gmail.com";

            #endregion

            request.Language = "TR";
            var response = MarketPlaceSale3DSecOrMpSaleRequest.Execute(request, settings);
            ServicesXmlResponse responseMessage = new ServicesXmlResponse();
            responseMessage.XmlResponse = response;
            return View(responseMessage);
        }



        public ActionResult MarketPlaceWDTicketMpSale3dSecWithUrl()
        {
            return View();

        }
        [HttpPost]
        public ActionResult MarketPlaceWDTicketMpSale3dSecWithUrl(int subPartnerId,string currencyCode)
        {

            MarketPlaceMPSale3DSECRequest request = new MarketPlaceMPSale3DSECRequest();
            request.ServiceType = "WDTicket";
            request.OperationType = "MPSale3DSECWithUrl";
            request.Price = 1; //0,01 TL
            request.MPAY = "01";
            request.CurrencyCode = currencyCode;
            request.Description = "Bilgisayar";
            request.CommissionRate = 1; //komisyon oranı 1. 100 ile çarpılıp gönderiliyor
            request.InstallmentOptions = 0;

            request.CommissionRateList = new CommissionRateList();
            request.CommissionRateList.Inst0 = 110;
            request.CommissionRateList.Inst3 = 130;
            request.CommissionRateList.Inst6 = 160;
            request.CommissionRateList.Inst9 = 190;


            request.ExtraParam = "";
            request.PaymentContent = "BLGSYR01";
            request.SubPartnerId = subPartnerId;
            request.ErrorURL = "http://localhost:1794/Home/Fail";
            request.SuccessURL = "http://localhost:1794/Home/Success";


            #region Token
            request.Token = new Token();
            request.Token.UserCode = settings.UserCode;
            request.Token.Pin = settings.Pin;
            #endregion
            #region CustomerInfo

            request.CustomerInfo = new CustomerInfo();
            request.CustomerInfo.CustomerName = "ahmet";
            request.CustomerInfo.CustomerSurname = "yılmaz";
            request.CustomerInfo.CustomerEmail = "ahmet.yilmaz@gmail.com";

            #endregion

            request.Language = "TR";
            var response = MarketPlaceMPSale3DSECRequest.Execute(request, settings);
            ServicesXmlResponse responseMessage = new ServicesXmlResponse();
            responseMessage.XmlResponse = response;
            return View(responseMessage);


        }




        public ActionResult MarketPlaceReleasePayment()
        {
            return View();
        }
        /// <summary>
        /// Pazaryeri Ödeme Onay servisi için subpartnerId bilgimizi web sayfasından alıyoruz.
        /// Hazırladığımız sınıfımızı https://www.wirecard.com.tr/SGate/Gate adresine post ediyoruz.
        /// Servis cevabını ekranda gösteriyoruz.
        /// </summary>
        /// <param name="subPartnerId"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult MarketPlaceReleasePayment(int subPartnerId)
        {
            var request = new MarketPlaceReleasePaymentRequest();

            request.ServiceType = "CCMarketPlace";
            request.OperationType = "ReleasePayment";
            request.SubPartnerId = subPartnerId;
            request.CommissionRate = 100; //%1
            request.MPAY = "";
            request.OrderId = Guid.NewGuid();
            request.Description = "Bilgisayar ödemesi";

            #region Token
            request.Token = new Token();
            request.Token.UserCode = settings.UserCode;
            request.Token.Pin = settings.Pin;
            #endregion

            var response = MarketPlaceReleasePaymentRequest.Execute(request, settings);
            ServicesXmlResponse responseMessage = new ServicesXmlResponse();
            responseMessage.XmlResponse = response;
            return View(responseMessage);
        }


        public ActionResult TransactionQueryByOrderId()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TransactionQueryByOrderId(string orderId)
        {
            _getSaleResultOrderService = new SaleServiceSoapClient(SaleServiceSoapClient.EndpointConfiguration.SaleServiceSoap);
           SaleService.MAuthToken token = new SaleService.MAuthToken();
            #region Token
            token.UserCode = base.settings.UserCode;
            token.Pin = base.settings.Pin;
            #endregion
            var guid = new Guid(orderId.ToString());
            var response = _getSaleResultOrderService.GetSaleResultAsync(token, guid).GetAwaiter().GetResult();
            return View(response);
        }

        public ActionResult TransactionQueryByMPAY()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TransactionQueryByMPAY(string MPAY)
        {
            _getSaleResultMpayService = new SaleServiceSoapClient(SaleServiceSoapClient.EndpointConfiguration.SaleServiceSoap);
           SaleService.MAuthToken token = new SaleService.MAuthToken();
            #region Token
            token.UserCode = base.settings.UserCode;
            token.Pin = base.settings.Pin;
            #endregion
            var response = _getSaleResultMpayService.GetSaleResultMPAYAsync(token, MPAY).GetAwaiter().GetResult();
            return View(response);
        }

        public ActionResult TokenizeCCURL()
        {

            return View();
        }




        [HttpPost]
        public ActionResult TokenizeCCURL(string customerId)
        {
            var request = new TokenizeCCURLRequest();

            request.ServiceType = "WDTicket";
            request.OperationType = "TokenizeCCURL";
            request.SuccessURL = "http://localhost:32123/Home/CardTokenizeSuccess";
            request.ErrorURL = "http://localhost:32123/Home/CardTokenizeFail";
            request.CustomerId = customerId;
            request.IPAddress = "";
            request.ValidityPeriod = "20";

            #region Token
            request.Token = new Token();
            request.Token.UserCode = settings.UserCode;
            request.Token.Pin = settings.Pin;
            #endregion

            var response = TokenizeCCURLRequest.Execute(request, settings);
            ServicesXmlResponse responseMessage = new ServicesXmlResponse();
            responseMessage.XmlResponse = response;
            return View(responseMessage);
        }




        public ActionResult TokenizeCC()
        {
            return View();
        }


        [HttpPost]
        public ActionResult TokenizeCC(string creditCardNo, string ownerName, int expireYear, int expireMonth, string cvv, string customerId)
        {
            var request = new TokenizeCCRequest();
            request.ServiceType = "CCTokenizationService";
            request.OperationType = "TokenizeCC";
            request.CustomerId = customerId;
            request.CreditCardNumber = creditCardNo;
            request.NameSurname = ownerName;
            request.ExpiryDate = expireMonth + "/" + expireYear;
            request.CVV = cvv;
            request.Port = "";
            request.IPAddress = "";
            request.ValidityPeriod = "20";
            #region Token
            request.Token = new Token();
            request.Token.UserCode = settings.UserCode;
            request.Token.Pin = settings.Pin;
            #endregion
            var response = TokenizeCCRequest.Execute(request, settings);
            ServicesXmlResponse responseMessage = new ServicesXmlResponse();
            responseMessage.XmlResponse = response;
            return View(responseMessage);
        }


        public ActionResult CardTokenizeSuccess()
        {
            var model = new CCTokenizeResponse();
            model.StatusCode = Request.Form["Statuscode"];
            model.ResultCode = Request.Form["ResultCode"];
            model.ResultMessage = Request.Form["ResultMessage"];
            model.TokenId = Request.Form["TokenId"];
            model.MaskedCCNo = Request.Form["MaskedCCNo"];
            model.CustomerId = Request.Form["CustomerId"];
            return View(model);

        }
        public ActionResult CardTokenizeFail()
        {
            var model = new CCTokenizeResponse();
            model.StatusCode = Request.Form["Statuscode"];
            model.ResultCode = Request.Form["ResultCode"];
            model.ResultMessage = Request.Form["ResultMessage"];
            model.TokenId = Request.Form["TokenId"];
            model.MaskedCCNo = Request.Form["MaskedCCNo"];
            model.CustomerId = Request.Form["CustomerId"];
            return View(model);
        }

        public ActionResult Success()
        {

            var model = new WDTicketPaymentFormBaseResponse();
            model.OrderId = Request.Form["OrderId"];
            model.MPay = Request.Form["MPAY"];
            model.StatusCode = Request.Form["Statuscode"];
            model.ResultCode = Request.Form["ResultCode"];
            model.ResultMessage = Request.Form["ResultMessage"];
            model.LastTransactionDate = Request.Form["LastTransactionDate"];
            model.MaskedCCNo = Request.Form["MaskedCCNo"];
            model.CCTokenId = Request.Form["CCTokenId"];
            model.ExtraParam = Request.Form["ExtraParam"];
            var hashparam = Request.Form["HashParam"];
            var hashText = Request.Form["Statuscode"] + Request.Form["LastTransactionDate"] + Request.Form["MPAY"] + Request.Form["OrderId"].ToString().ToLower() + base.settings.HashKey;
            var hashedText = Helper.ComputeHash(hashText);
            if (hashparam == hashedText)
            {
                //Gelen Hash değerinin doğru hesaplanmış olması işlem güvenliği açısından önemlidir !
            }


            return View(model);
        }
        public ActionResult Fail()
        {
            var model = new WDTicketPaymentFormBaseResponse();
            model.OrderId = Request.Form["OrderId"];
            model.MPay = Request.Form["MPAY"];
            model.StatusCode = Request.Form["Statuscode"];
            model.ResultCode = Request.Form["ResultCode"];
            model.ResultMessage = Request.Form["ResultMessage"];
            model.LastTransactionDate = Request.Form["LastTransactionDate"];
            model.MaskedCCNo = Request.Form["MaskedCCNo"];
            model.CCTokenId = Request.Form["CCTokenId"];
            model.ExtraParam = Request.Form["ExtraParam"];
            return View(model);
        }
    }
}
