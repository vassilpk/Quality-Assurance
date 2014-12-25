﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TALS.PerformanceTesting.WebTest.Modules.KidsAcademy.RegistrationForm
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.WebTesting;
    using Microsoft.VisualStudio.TestTools.WebTesting.Rules;
    using TALS.PerformanceTesting.Utils.RandomDataProvider;


    public class FrontRegisterUserCoded : WebTest
    {

        public FrontRegisterUserCoded()
        {
            this.PreAuthenticate = true;
            this.Proxy = "default";
        }

        public override IEnumerator<WebTestRequest> GetRequestEnumerator()
        {
            // Initialize validation rules that apply to all requests in the WebTest
            if ((this.Context.ValidationLevel >= Microsoft.VisualStudio.TestTools.WebTesting.ValidationLevel.Low))
            {
                ValidateResponseUrl validationRule1 = new ValidateResponseUrl();
                this.ValidateResponse += new EventHandler<ValidationEventArgs>(validationRule1.Validate);
            }
            if ((this.Context.ValidationLevel >= Microsoft.VisualStudio.TestTools.WebTesting.ValidationLevel.Low))
            {
                ValidationRuleResponseTimeGoal validationRule2 = new ValidationRuleResponseTimeGoal();
                validationRule2.Tolerance = 0D;
                this.ValidateResponseOnPageComplete += new EventHandler<ValidationEventArgs>(validationRule2.Validate);
            }

            WebTestRequest request1 = new WebTestRequest("http://test.telerikacademy.com/KidsAcademy/Registration/");
            request1.ThinkTime = 6;
            yield return request1;
            request1 = null;

            WebTestRequest request2 = new WebTestRequest("http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia");
            request2.ThinkTime = 228;
            request2.Headers.Add(new WebTestRequestHeader("Referer", "http://test.telerikacademy.com/KidsAcademy/Registration/"));
            ExtractHiddenFields extractionRule1 = new ExtractHiddenFields();
            extractionRule1.Required = true;
            extractionRule1.HtmlDecode = true;
            extractionRule1.ContextParameterName = "1";
            request2.ExtractValues += new EventHandler<ExtractionEventArgs>(extractionRule1.Extract);
            yield return request2;
            request2 = null;

            WebTestRequest request3 = new WebTestRequest("http://test.telerikacademy.com/KidsAcademy/Registration/Sofia");
            request3.ThinkTime = 8;
            request3.Method = "POST";
            request3.ExpectedResponseUrl = "http://test.telerikacademy.com/KidsAcademy/Candidate/SelectExamDate";
            request3.Headers.Add(new WebTestRequestHeader("Referer", "http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia"));
            FormPostHttpBody request3Body = new FormPostHttpBody();
            request3Body.FormPostParameters.Add("__RequestVerificationToken", this.Context["$HIDDEN1.__RequestVerificationToken"].ToString());
            request3Body.FormPostParameters.Add("Username", RandomStringProvider.GetRandomString(6));

            var password = RandomStringProvider.GetRandomString(6);
            request3Body.FormPostParameters.Add("Password", password);
            request3Body.FormPostParameters.Add("PasswordAgain", password);
            request3Body.FormPostParameters.Add("Email", RandomStringProvider.GetRandomEmail());
            request3Body.FormPostParameters.Add("FirstName", RandomStringProvider.GetRandomBulgarianString(6));
            request3Body.FormPostParameters.Add("LastName", RandomStringProvider.GetRandomBulgarianString(6));
            request3Body.FormPostParameters.Add("BirthDay", RandomStringProvider.GetRandomDateAfter("01/01/2001"));
            request3Body.FormPostParameters.Add("IsMale", "True");
            request3Body.FormPostParameters.Add("Phone", "");
            request3Body.FormPostParameters.Add("SchoolName", "");
            request3Body.FormPostParameters.Add("ClassId", "5");
            request3Body.FormPostParameters.Add("CityId_input", "");
            request3Body.FormPostParameters.Add("CityId", "");
            request3Body.FormPostParameters.Add("About", "");
            request3Body.FormPostParameters.Add("ParentFirstName", RandomStringProvider.GetRandomBulgarianString(6));
            request3Body.FormPostParameters.Add("ParentLastName", RandomStringProvider.GetRandomBulgarianString(6));
            request3Body.FormPostParameters.Add("ParentEmail", RandomStringProvider.GetRandomEmail());
            request3Body.FormPostParameters.Add("ParentPhone", RandomStringProvider.GetRandomPhoneNumber());
            request3Body.FormPostParameters.Add("TermsAndConditions", "true");
            request3Body.FormPostParameters.Add("TermsAndConditions", this.Context["$HIDDEN1.TermsAndConditions"].ToString());
            request3Body.FormPostParameters.Add("KidsSchoolCityId", this.Context["$HIDDEN1.KidsSchoolCityId"].ToString());
            request3Body.FormPostParameters.Add("KidsSchoolCityName", this.Context["$HIDDEN1.KidsSchoolCityName"].ToString());
            request3.Body = request3Body;
            yield return request3;
            request3 = null;

            WebTestRequest request4 = new WebTestRequest("http://test.telerikacademy.com/Users/Auth/LogOut");
            request4.ThinkTime = 1;
            request4.ExpectedResponseUrl = "http://test.telerikacademy.com/";
            request4.Headers.Add(new WebTestRequestHeader("Referer", "http://test.telerikacademy.com/KidsAcademy/Candidate/SelectExamDate"));
            yield return request4;
            request4 = null;
        }
    }
}