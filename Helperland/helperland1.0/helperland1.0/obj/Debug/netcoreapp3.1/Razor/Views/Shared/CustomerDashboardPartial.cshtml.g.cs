#pragma checksum "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b1cd60350c6c264a8010f7fb6c1a3963ba2cd03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_CustomerDashboardPartial), @"mvc.1.0.view", @"/Views/Shared/CustomerDashboardPartial.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\_ViewImports.cshtml"
using helperland1._0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\_ViewImports.cshtml"
using helperland1._0.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b1cd60350c6c264a8010f7fb6c1a3963ba2cd03", @"/Views/Shared/CustomerDashboardPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccf1df5a63102c4cf8f6f3232c926fcf06626c10", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_CustomerDashboardPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<helperland1._0.ViewModel.CustomerDashboard>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BookService", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
  
String CurrentDate = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n");
#nullable restore
#line 9 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
  
    int ServiceDashboardCount = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"dashboard\" class=\"tab-contant\">\n    <div class=\"clearfix\">\n        <div class=\"d-flex justify-content-between\">\n            <p class=\"alignleft \"> Customer Service Request </p>\n\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b1cd60350c6c264a8010f7fb6c1a3963ba2cd034623", async() => {
                WriteLiteral(" <button class=\"alignright \">Add new request</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

        </div>
        <table id=""dashbordTable"" class=""table"">
            <thead class=""table-light"">
                <tr class=""text-center"">
                    <th scope=""col"" style=""width: 17%""> Service ID <img src=""/image/sort.png""></th>
                    <th scope=""col"" style=""width: 20%""> Service Date <img src=""/image/sort.png""> </th>
                    <th scope=""col"" style=""width: 30%""> Service Provider <img src=""/image/sort.png""> </th>
                    <th scope=""col"" style=""width: 15%""> Payment <img src=""/image/sort.png""> </th>
                    <th scope=""col"" style=""width: 9% ;text-align:end;padding-right:0px""> Acti</th>
                    <th scope=""col"" style=""width: 9%  ;text-align:start;padding-left:0px"""">on</th>

                </tr>
            </thead>
            <tbody>


");
#nullable restore
#line 35 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                 if (Model.Count() > 0)
                {

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                     foreach (var item in Model)
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                         if (item.Status == 1 || item.Status == 2)
                        {

                            ServiceDashboardCount = ServiceDashboardCount + 1;


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr data-value=");
#nullable restore
#line 46 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                                      Write(item.ServiceRequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" class=\"text-center\">\n                                <td data-label=\"Service ID\">\n\n                                    <p>");
#nullable restore
#line 49 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                                  Write(item.ServiceRequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n                                </td>\n                                <td data-label=\"Service Date\">\n                                    <div> <img src=\"/image/calendar.png\" alt=\"calender\"> ");
#nullable restore
#line 53 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                                                                                    Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\n                                    <p class=\"service-time\"> ");
#nullable restore
#line 54 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                                                        Write(item.StartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 54 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                                                                          Write(item.EndTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n\n                                </td>\n\n                                <td data-label=\"Service Provider\" class=\"clearfix\">\n");
#nullable restore
#line 59 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                                    if (item.ServiceProvider != null)
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"cap-icon\"> <img");
            BeginWriteAttribute("src", " src=", 2438, "", 2467, 1);
#nullable restore
#line 62 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
WriteAttributeValue("", 2443, item.UserProfilePicture, 2443, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"spavtar\" alt=\"..\"> </div><div style=\"font-weight:400\" class=\"text-start\"> ");
#nullable restore
#line 62 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                                                                                                                                                                             Write(item.ServiceProvider);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                                        <div>\n");
#nullable restore
#line 64 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                                             for (int i = 1; i <= 5; i++)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                                                 if (i <= item.AverageRating)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <i class=\"fa fa-star \" style=\"color:#ECB91C;\"></i>\n");
#nullable restore
#line 69 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"

                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <i class=\"fa fa-star \" style=\"color:silver;\"></i>\n");
#nullable restore
#line 74 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"

                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                                                 

                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>");
#nullable restore
#line 78 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                                             Write(item.AverageRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                        </div>\n");
#nullable restore
#line 80 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\n\n\n                                <td data-label=\"Payment\">\n                                    <p class=\"price\">&euro; ");
#nullable restore
#line 85 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                                                       Write(item.TotalCost);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                                </td>

                                                
                                <td data-label=""Reschedule""> <button class=""customerReschedule"" style=""float:right"" data-bs-toggle=""modal"" data-bs-target=""#rescheduleModelServiceRequest""");
            BeginWriteAttribute("value", " value=", 3943, "", 3972, 1);
#nullable restore
#line 89 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
WriteAttributeValue("", 3950, item.ServiceRequestId, 3950, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Reschedule</button></td>\n                                <td data-label=\"Cancel\" ><button class=\"customerCancel\" data-bs-toggle=\"modal\" data-bs-target=\"#deleteModelServiceRequest\"");
            BeginWriteAttribute("value", " value=", 4152, "", 4181, 1);
#nullable restore
#line 90 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
WriteAttributeValue("", 4159, item.ServiceRequestId, 4159, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cancel</button></td>\n                            </tr>\n");
#nullable restore
#line 92 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n\n\n\n\n\n        \n        <div class=\"card mobileview clearfix mx-auto\" style=\"width:100%; padding:0% 5% 0% 5%; \">\n");
#nullable restore
#line 104 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
             if (Model.Count() > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                 foreach (var item in Model)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                     if (item.Status == 1 || item.Status == 2)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card-body\" data-value=");
#nullable restore
#line 111 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                                                     Write(item.ServiceRequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\n                            <h6 class=\"d-inline pe-2\">Service Id : </h6> ");
#nullable restore
#line 112 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                                                                    Write(item.ServiceRequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            <hr />
                            <span>


                                <img src=""/image/calendar.png"" alt=""calender""><h6 class=""d-inline pe-2 ""> <span class=""d-none d-sm-block"">Service</span>  Date:</h6><span class=""date mb-0"">");
#nullable restore
#line 117 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                                                                                                                                                                                       Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br>\n                                <img src=\"/image/clock.png\" alt=\"calender\"><h6 class=\"pe-2 d-inline  \"><span class=\"d-none d-sm-block\">Service</span> Time:</h6> ");
#nullable restore
#line 118 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                                                                                                                                                            Write(item.StartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 118 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                                                                                                                                                                              Write(item.EndTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n                            </span>\n                            <hr>\n");
#nullable restore
#line 123 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                             if (item.ServiceProvider != null)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h6 class=\"pe-2 \">Service Provider Name:</h6>\n                                <div class=\"cap-icon\">  <img");
            BeginWriteAttribute("src", " src=", 5607, "", 5636, 1);
#nullable restore
#line 127 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
WriteAttributeValue("", 5612, item.UserProfilePicture, 5612, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"..\">   </div>\n");
#nullable restore
#line 128 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                           Write(item.ServiceProvider);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div>\n");
#nullable restore
#line 130 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                                   for (int i = 1; i <= 5; i++)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                                                 if (i <= item.AverageRating)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <i class=\"fa fa-star \" style=\"color:#ECB91C;\"></i>\n");
#nullable restore
#line 135 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"

                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <i class=\"fa fa-star \" style=\"color:silver;\"></i>\n");
#nullable restore
#line 140 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"

                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 141 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                                                 

                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span>");
#nullable restore
#line 144 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                                     Write(item.AverageRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                </div>\n");
            WriteLiteral("                                <hr />\n");
#nullable restore
#line 148 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"




                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                            <p class=\"price\"><h6 class=\"d-inline pe-2\">Price:</h6> &euro; ");
#nullable restore
#line 155 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                                                                                     Write(item.TotalCost);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n                            <hr>\n                            <div class=\"d-flex justify-content-around\">\n                                <button class=\"customerReschedule\"");
            BeginWriteAttribute("value", " value=", 6909, "", 6938, 1);
#nullable restore
#line 158 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
WriteAttributeValue("", 6916, item.ServiceRequestId, 6916, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-bs-toggle=\"modal\" data-bs-target=\"#rescheduleModelServiceRequest\">Reschedule</button>\n\n                                <button class=\"customerCancel\"");
            BeginWriteAttribute("value", " value=", 7093, "", 7122, 1);
#nullable restore
#line 160 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
WriteAttributeValue("", 7100, item.ServiceRequestId, 7100, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-bs-toggle=\"modal\" data-bs-target=\"#deleteModelServiceRequest\">Cancel</button>\n                            </div>\n                        </div>\n");
#nullable restore
#line 163 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 163 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 164 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                 

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>


        

        
        


       
    </div>

  

</div>





<div class=""modal"" tabindex=""-1"" id=""deleteModelServiceRequest"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">
             <input type=""hidden"" id=""CancelRequestId"" name=""CancelRequestId"" />
            <div class=""modal-header"">
                <h5 class=""modal-title"">Cancel Service Request</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <label for=""comment"" class=""form-label"">Why you want to cancel the service request?</label>
                <textarea class=""form-control"" id=""cancelReason"" rows=""3""></textarea>
                <div class=""text-center"">
                    <button class=""customerCancel"" type=""button"" data-bs-dismiss=""modal"" class=""mt-2 cancel"" id=""CancelRequestBtn"">Cancel Now</button>
                </div>
            </div>
     ");
            WriteLiteral("   </div>\n    </div>\n</div>\n\n");
            WriteLiteral(@"
<button id=""serviceReqdetailsbtn"" data-bs-toggle=""modal"" data-bs-target=""#detailsModelServiceRequest"" class=""d-none"">details</button>


<div class=""modal"" tabindex=""-1"" id=""detailsModelServiceRequest"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content text-start"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Service Details</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body float-start"">
                <h4 id=""CDSDDateTime"">05/10/2021 08:00 - 11:30</h4>
                <p>Duration: <span id=""CDSDDuration""></span> </p>
                <hr>
                <p>Service id: <span id=""CDSDId""></span></p>
                <div class=""row""> <p class=""col-2 d-inline"">Extras: </p> <div class=""col-10 d-inline"" id=""CDSDExtra""></div></div>

                <p>Net Amount: <span id=""CDSDAmount"">8750 &euro;</span> </p>
                <p i");
            WriteLiteral(@"d=""CDSDStatus""></p>
                <hr>
                <p>Service Address:<span id=""CDSDAddress""></span></p>
                <p>Billing Address: <span>same as cleaninng address</span></p>
                <p>phone:<span id=""CDSDPhone""></span></p>
                <p>Email:<span id=""CDSDEmail""> </span></p>
                <hr>

                <p>Comments <span id=""CDSDComment""></span></p>
");
            WriteLiteral(@"                <span id=""customerdashboardbtn"">
                   <hr>



                    <div class=""text-center  d-flex justify-content-around"">
                        <button class=""customerReschedule"" data-bs-toggle=""modal"" data-bs-target=""#rescheduleModelServiceRequest"" id=""' '"">Reschedule</button><button class=""customerCancel"" data-bs-toggle=""modal"" data-bs-target=""#deleteModelServiceRequest"">Cancel</button>
                    </div> 

                </span>
");
            WriteLiteral(@"                <span id=""customerServiceHistorybtn"">
                    <hr>



                    <div class=""text-center  d-flex justify-content-around"">
                        <button class=""rate"" data-bs-toggle=""modal"" data-bs-target=""#myRatingModal"" >Rate </button>
                    </div>

                </span>

            </div>
        </div>
    </div>
</div>








");
            WriteLiteral(@"<div class=""modal"" tabindex=""-1"" id=""rescheduleModelServiceRequest"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Reschedule Service Request</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <p>Select New Date & Time</p>
                <div class=""row"">
                    <div class=""col-sm-6 col-12""> <input id=""selected_date"" type=""date"" value=");
#nullable restore
#line 281 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                                                                                         Write(CurrentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("  placeholder=\"canlender\" min=");
#nullable restore
#line 281 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\CustomerDashboardPartial.cshtml"
                                                                                                                                   Write(CurrentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"></div>
                    <div class=""col-sm-6 col-12"">
                         <input type=""hidden"" id=""updateRequestId"" name=""updateRequestId"" />
                        <select class=""form-select"" id=""selected_time"">
                           <option selected value=""08:00:00"">8:00 </option>
										<option value=""08:30:00"">8:30 </option>
										<option value=""09:00:00"">9:00 </option>
										<option value=""09:30:00"">9:30 </option>
										<option value=""10:00:00"">10:00 </option>
										<option value=""10:30:00"">10:30 </option>
										<option value=""11:00:00"">11:00 </option>
										<option value=""11:30:00"">11:30 </option>
										<option value=""12:00:00""> 12:00  </option>
										<option value=""12:30:00"">12:30 </option>
										<option value=""13:00:00""> 13:00  </option>
										<option value=""13:30:00"">13:30 </option>
										<option value=""14:00:00""> 14:00  </option>
										<option value=""14:30:00"">14:30 </option>
										<option value=""15:00:00""> 15:00  </option>
						");
            WriteLiteral(@"				<option value=""15:30:00"">15:30 </option>
										<option value=""16:00:00""> 16:00  </option>
										<option value=""16:30:00"">16:30 </option>
										<option value=""17:00:00""> 17:00  </option>
										<option value=""17:30:00"">17:30 </option>
										<option value=""18:00:00""> 18:00  </option>

                        </select>
                    </div>
                </div>
                <div class=""text-center"">
                    <button id=""RescheduleServiceRequest"" type=""submit"" data-bs-dismiss=""modal"" class=""customerReschedule"" >Update</button>
                </div>
            </div>
        </div>
    </div>
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<helperland1._0.ViewModel.CustomerDashboard>> Html { get; private set; }
    }
}
#pragma warning restore 1591