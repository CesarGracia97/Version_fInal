#pragma checksum "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39c02b0c173df73bc91cef6ca30fb631b43ac23e"
// <auto-generated/>
#pragma warning disable 1591
namespace Tecnologico.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\_Imports.razor"
using Tecnologico.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\_Imports.razor"
using Tecnologico.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\Pages\Index.razor"
using Tecnologico.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Syncfusion.Blazor.Grids.SfGrid<Dato>>(0);
            __builder.AddAttribute(1, "Toolbar", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\Pages\Index.razor"
                                 new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel" }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Data.SfDataManager>(3);
                __builder2.AddAttribute(4, "Url", "/api/Datos");
                __builder2.AddAttribute(5, "Adaptor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Adaptors>(
#nullable restore
#line 5 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\Pages\Index.razor"
                                             Adaptors.WebApiAdaptor

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEditSettings>(7);
                __builder2.AddAttribute(8, "AllowAdding", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\Pages\Index.razor"
                                   true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "AllowEditing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\Pages\Index.razor"
                                                       true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "AllowDeleting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\Pages\Index.razor"
                                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(12);
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(14);
                    __builder3.AddAttribute(15, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\Pages\Index.razor"
                            nameof(Dato.Id)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "IsPrimaryKey", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\Pages\Index.razor"
                                                           true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\Pages\Index.razor"
                                                                          false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(19);
                    __builder3.AddAttribute(20, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\Pages\Index.razor"
                            nameof(Dato.NombreCliente)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "Width", "150");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(23);
                    __builder3.AddAttribute(24, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\Pages\Index.razor"
                            nameof(Dato.Producto)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "Width", "150");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(27);
                    __builder3.AddAttribute(28, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\Pages\Index.razor"
                            nameof(Dato.Precio)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "ValidationRules", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.ValidationRules>(
#nullable restore
#line 11 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\Pages\Index.razor"
                                                                    new ValidationRules(){ Range = new double[]{ 1, 1000 } }

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "Width", "90");
                    __builder3.AddAttribute(31, "Format", "C2");
                    __builder3.AddAttribute(32, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 11 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\Pages\Index.razor"
                                                                                                                                                                 TextAlign.Right

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(34);
                    __builder3.AddAttribute(35, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\Pages\Index.razor"
                            nameof(Dato.Stock)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "DisplayAsCheckBox", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\Pages\Index.razor"
                                                                   true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "Width", "70");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEvents<Dato>>(39);
                __builder2.AddAttribute(40, "OnActionFailure", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Grids.FailureEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Grids.FailureEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\Pages\Index.razor"
                                               Failure

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\narut\Escritorio\PA\P2 VC - copia\blazor-wasm-datagrid-efcore-crud-main\Libreria\Client\Pages\Index.razor"
      
    
    private void Failure(FailureEventArgs e) {
        Console.WriteLine(e.Error.Message);
        Console.WriteLine(e.Error.StackTrace);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
