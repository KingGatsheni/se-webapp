#pragma checksum "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Booking\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45d3ec045723814821ce44ada4400c8d0d1202e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Success), @"mvc.1.0.view", @"/Views/Booking/Success.cshtml")]
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
#line 1 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\_ViewImports.cshtml"
using homecoming.webapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\_ViewImports.cshtml"
using homecoming.webapp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Booking\Success.cshtml"
using homecoming.webapp.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45d3ec045723814821ce44ada4400c8d0d1202e2", @"/Views/Booking/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53b6caf8dd4338175d51ef9c15eacd1d128426b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<homecoming.webapp.ViewModel.BookingViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<div class=""container"" style=""left:160px"">
    <h4 class=""text-center"" style=""margin-top:80px; right:50px"">Booking Details</h4>
    <h3 class=""text-center"" style=""margin-top:40px; right:50px; color:forestgreen""> Booking Successful, Pay on Checkin </h3>
    <table class=""styled-table"">
        <thead>
            <tr>
                <th>
                    BookingId
                </th>
                <th>
                    Price
                </th>
                <th>
                    Days Booked
                </th>
                <th>
                    Number Of Rooms Booked
                </th>
                <th>
                    CheckIn
                </th>
                <th>
                    CheckOut
                </th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>
                    ");
#nullable restore
#line 35 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Booking\Success.cshtml"
               Write(Model.BookingId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Booking\Success.cshtml"
               Write(Model.BookingPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Booking\Success.cshtml"
               Write(Model.NoOfDaysBooked);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Booking\Success.cshtml"
               Write(Model.NoOfRooms);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Booking\Success.cshtml"
               Write(Model.Check_In_Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Booking\Success.cshtml"
               Write(Model.Check_Out_Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
#nullable restore
#line 57 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Booking\Success.cshtml"
 if(TempData["status"] != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n        alert(\'");
#nullable restore
#line 59 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Booking\Success.cshtml"
          Write(Html.Raw(TempData["status"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\')\r\n</script>\r\n");
#nullable restore
#line 61 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Booking\Success.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<homecoming.webapp.ViewModel.BookingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
