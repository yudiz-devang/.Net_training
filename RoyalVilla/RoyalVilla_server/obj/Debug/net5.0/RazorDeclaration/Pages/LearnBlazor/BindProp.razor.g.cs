// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RoyalVilla_server.Pages.LearnBlazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Yudiz\Devang\W\Blazzor-Practice\RoyalVilla\RoyalVilla_server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Yudiz\Devang\W\Blazzor-Practice\RoyalVilla\RoyalVilla_server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Yudiz\Devang\W\Blazzor-Practice\RoyalVilla\RoyalVilla_server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Yudiz\Devang\W\Blazzor-Practice\RoyalVilla\RoyalVilla_server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Yudiz\Devang\W\Blazzor-Practice\RoyalVilla\RoyalVilla_server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Yudiz\Devang\W\Blazzor-Practice\RoyalVilla\RoyalVilla_server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Yudiz\Devang\W\Blazzor-Practice\RoyalVilla\RoyalVilla_server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Yudiz\Devang\W\Blazzor-Practice\RoyalVilla\RoyalVilla_server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Yudiz\Devang\W\Blazzor-Practice\RoyalVilla\RoyalVilla_server\_Imports.razor"
using RoyalVilla_server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Yudiz\Devang\W\Blazzor-Practice\RoyalVilla\RoyalVilla_server\_Imports.razor"
using RoyalVilla_server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Yudiz\Devang\W\Blazzor-Practice\RoyalVilla\RoyalVilla_server\Pages\LearnBlazor\BindProp.razor"
using Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bindprop")]
    public partial class BindProp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Yudiz\Devang\W\Blazzor-Practice\RoyalVilla\RoyalVilla_server\Pages\LearnBlazor\BindProp.razor"
       
    string SelectRoomProp = "";
    List<BlazorRoom> RoomList = new List<BlazorRoom>();
    BlazorRoom Room = new BlazorRoom()
        {
            Id = 1,
            RoomName = "Villa Suite",
            Price = 899,
            IsActive = true,
            RoomProp = new List<BlazorRoomProp>{
                new Model.BlazorRoomProp{Id=1,Name="Sq Ft",Value="100"},
                new Model.BlazorRoomProp{Id=2,Name="Occupancy",Value="3"}
            }
        };
    protected override void OnInitialized()
    {
        base.OnInitialized();
        RoomList.Add(new BlazorRoom()
            {
                Id = 101,
                RoomName = "Villa Suite",
                Price = 899,
                IsActive = true,
                RoomProp = new List<BlazorRoomProp>{
                new Model.BlazorRoomProp{Id=1,Name="Sq Ft",Value="100"},
                new Model.BlazorRoomProp{Id=2,Name="Occupancy",Value="3"}
            }
            });

        RoomList.Add(new BlazorRoom()
            {
                Id = 201,
                RoomName = "Villa Suite Two Bed Room",
                Price = 1499,
                IsActive = true,
                RoomProp = new List<BlazorRoomProp>{
                new Model.BlazorRoomProp{Id=1,Name="Sq Ft",Value="300"},
                new Model.BlazorRoomProp{Id=2,Name="Occupancy",Value="3"}
            }
            });
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
