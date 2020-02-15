#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Views/Boards/SprintBacklogs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdd90b7be27fd8dc484aa57f3c047cf6dc788ae2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Boards_SprintBacklogs), @"mvc.1.0.view", @"/Views/Boards/SprintBacklogs.cshtml")]
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
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Views/_ViewImports.cshtml"
using Rokono_Control;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Views/_ViewImports.cshtml"
using Rokono_Control.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdd90b7be27fd8dc484aa57f3c047cf6dc788ae2", @"/Views/Boards/SprintBacklogs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Boards_SprintBacklogs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Syncfusion/ej2/material.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Syncfusion/ej2/dist/ej2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Views/Boards/SprintBacklogs.cshtml"
  
    ViewData["Title"] = "Backlog";
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";
    var result = ViewData["ProjectId"] as int?;
    var BoardId = ViewData["BoardId"] as int?;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fdd90b7be27fd8dc484aa57f3c047cf6dc788ae24565", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<!-- end of sidebar element -->
<!-- main-content declaration -->
<div class=""main-content"" id=""main-text"">
    <div class=""sidebar-content"">
        <div class=""row"" style=""margin:0px;"">
            <div class=""col-md-12"">
                <div class=""main-card mb-3 card"">
                    <div class=""card-body"">
                        <h5 class=""card-title text-center"">Select a project</h5>
                        <div class=""row"" style=""margin-left:10px;"">

                            <div class=""btn-group dropdown-split-primary"">
                                <button type=""button"" id=""iconbtn"" class=""btn btn-primary"">New Work Item</button>

                                <button id=""QueryBtn"">View as board</button>
                                <button id=""ImportWorkItemBtn""></i>Email report</button>
                                <button id=""ExportWorkItemBtn"">Export Work Items</button>

                            </div>
                            <div class=""control-section"" style=""height:9");
            WriteLiteral(@"7vh;"">
                                <div class=""content-wrapper"">
                                    <div id=""TreeGrid""></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div id=""modalDialog"">
        <div class=""btn-group dropdown-split-primary"" style=""text-align:center;"">
            <button id=""taskBtn"" onclick=""NewTask()"">Task</button>
            <button id=""issueBtn"" onclick=""NewIssue()""></i>Issue</button>
            <button id=""bugBtn"" onclick=""NewBug()"">Bug</button>
        </div>
    </div>
    <script src=""https://code.jquery.com/jquery-3.4.1.min.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/boot");
            WriteLiteral("strap.min.js\" integrity=\"sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6\" crossorigin=\"anonymous\"></script>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdd90b7be27fd8dc484aa57f3c047cf6dc788ae27983", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n    <script>\n    ej.treegrid.TreeGrid.Inject(ej.treegrid.Edit, ej.treegrid.CommandColumn);\n\n    var treeGridObj;\n    var dialogObj;\n    var ProjectId = ");
#nullable restore
#line 59 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Views/Boards/SprintBacklogs.cshtml"
               Write(result);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n    var  boardId = ");
#nullable restore
#line 60 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Views/Boards/SprintBacklogs.cshtml"
              Write(BoardId);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n    var selected;\n    function OpenWorkItem(id)\n    {\n        console.log(id);\n    }\n    $( document ).ready(function()\n    {\n        var id = ");
#nullable restore
#line 68 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Views/Boards/SprintBacklogs.cshtml"
            Write(result);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

          var dto = {
            ""id"": id,
            ""WorkItemType"": 7
        }
        console.log(dto);
        $.ajax({
            type: 'POST',
            url: '/Backlogs/GetBacklogWorkItems',
            data: JSON.stringify(dto),
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (response) {
                InitiliazeGrid(response);
            },
            error: function (xhr, status, error) {
                console.log(error);
            }
        });
        dialogObj = new ej.popups.Dialog({
            width: '600px',
            header: 'Choose you the type of work item that you want to associate with the current user story!',
            isModal: false,
            animationSettings: { effect: 'None' },
            visible: false,

            open: dialogOpen,
            close: dialogClose
        });
        dialogObj.appendTo('#modalDialog');
        dialogObj.hide();
    });

    ej.base.enableRipple(true);
 ");
            WriteLiteral(@"   //Menu Btns
    var queryBtn = new ej.buttons.Button({ cssClass: 'e-outline', isPrimary: true });
    queryBtn.appendTo('#QueryBtn');
    var importWorkItemBtn = new ej.buttons.Button({ cssClass: 'e-outline', isPrimary: true });
    importWorkItemBtn.appendTo('#ImportWorkItemBtn');
    var exportWorkItemBtn = new ej.buttons.Button({ cssClass: 'e-outline', isPrimary: true });
    exportWorkItemBtn.appendTo('#ExportWorkItemBtn');
    var recycleBtn = new ej.buttons.Button({ cssClass: 'e-outline', isPrimary: true });
    recycleBtn.appendTo('#RecycleBtn');

    //Dialog btns
    var taskBtn = new ej.buttons.Button({ cssClass: 'e-outline', isPrimary: true });
    taskBtn.appendTo('#taskBtn');
    var bugBtn = new ej.buttons.Button({ cssClass: 'e-outline', isPrimary: true });
    bugBtn.appendTo('#bugBtn');
    var issueBtn = new ej.buttons.Button({ cssClass: 'e-outline', isPrimary: true });
    issueBtn.appendTo('#issueBtn');


    // DropDownButton items declaration
    var items = [
        {
            tex");
            WriteLiteral(@"t: 'Feature',
            iconCss: 'e-ddb-icons e-dashboard',

            url:""/Dashboard/AddNewWorkItem?projectId=""+ProjectId+""&workItemType=""+2+""&boardId=""+boardId+""&parentId=0""
        },
        {
            text: 'User Story',
            iconCss: 'e-ddb-icons e-notifications',
             url:""/Dashboard/AddNewWorkItem?projectId=""+ProjectId+""&workItemType=""+7+""&boardId=""+boardId+""&parentId=0""

        },
        {
            text: 'Task',
            iconCss: 'e-ddb-icons e-settings',
            url:""/Dashboard/AddNewWorkItem?projectId=""+ProjectId+""&workItemType=""+3+""&boardId=""+boardId+""&parentId=0""

        },
        {
            text: 'Bug',
            iconCss: 'e-ddb-icons e-logout',
            url:""/Dashboard/AddNewWorkItem?projectId=""+ProjectId+""&workItemType=""+1+""&boardId=""+boardId+""&parentId=0""
        },
        {
            text: 'Issue',
            iconCss: 'e-ddb-icons e-logout',
            url:""/Dashboard/AddNewWorkItem?projectId=""+ProjectId+""&workItemType=""+6+""&boardId=""+boardId");
            WriteLiteral(@"+""&parentId=0""

        },
        {
            text: 'Test',
            iconCss: 'e-ddb-icons e-logout',
            url:""/Dashboard/AddNewWorkItem?projectId=""+ProjectId+""&workItemType=""+4+""&boardId=""+boardId+""&parentId=0""
         }

        ];

    var btnObj = new ej.splitbuttons.DropDownButton({ items: items, iconCss: 'e-ddb-icons e-profile',cssClass: 'e-outline', select:WorkItemListClicked });
    btnObj.appendTo('#iconbtn');

    function WorkItemListClicked(args)
    {
        console.log(args);
        var url = args.properties.url;
        window.location.href = url;
       // console.log(args);
    }

    var onClick = function(args){
        var rowIndex = ej.base.closest(args.target, '.e-row').rowIndex;
        var data = treeGridObj.getCurrentViewRecords();
        console.log(data[rowIndex]);
        if(data[rowIndex].typeId === 5)
            window.location.href = ""/Dashboard/AddNewWorkItem?projectId=""+ProjectId+""&workItemType=""+2+""&boardId=""+boardId+""&parentId=""+data[rowIndex].id;
        ");
            WriteLiteral(@"if(data[rowIndex].typeId === 2)
            window.location.href = ""/Dashboard/AddNewWorkItem?projectId=""+ProjectId+""&workItemType=""+7+""&boardId=""+boardId+""&parentId=""+data[rowIndex].id;
        if(data[rowIndex].typeId === 7)
            CallChoiceMenu(data[rowIndex]);
     }
    function CallChoiceMenu(row)
    {
        selected = row;
        dialogObj.show();
    }
    function InitiliazeGrid(data )
    {
        console.log(data);


        treeGridObj = new ej.treegrid.TreeGrid({
            dataSource: data,
            allowSelection: true,
            allowFiltering: true,
            allowSorting: true,
            allowResizing: true,
            rowSelecting : GetCurrentRow,
            childMapping: 'subtasks',
            toolbar: ['Search'],
            recordDoubleClick: EditWorkItem,
            filterSettings: { type: 'Menu' },
            treeColumnIndex: 1,
            allowPaging: true,
            cellEdit: AddNewWorkItem,
            pageSettings: { pageCount: 2 },
            columns:");
            WriteLiteral(@" [
                {
                    headerText: 'Manage Records', width: 130,
                    commands: [{ type: 'Edit', buttonOption: { iconCss: ' e-icons e-edit', cssClass: 'e-flat', click:onClick } },
                   ]
                },
                { field: 'WorkItemType.TypeName', headerText: 'Title', width: 60 },
                { field: 'title', headerText: 'Title', width: 125 },
                { field: 'description', headerText: 'Description', width: 180 },
                { field: 'assignedAccountNavigation.Email', headerText: 'AssignedTo', width: 110 },
            ]
        });

        treeGridObj.appendTo('#TreeGrid');


    }
    function CreateNewWorkItem(id){
        ProjectId = ");
#nullable restore
#line 226 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Views/Boards/SprintBacklogs.cshtml"
               Write(result);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n        boardId = ");
#nullable restore
#line 227 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Views/Boards/SprintBacklogs.cshtml"
             Write(BoardId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
        window.location.href = ""/Dashboard/AddNewWorkItem?projectId=""+ProjectId+""&workItemType=""+id+""&boardId=""+boardId+""&parentId=0"";
    }

    function GetCurrentRow(args)
    {
        console.log(args);
        selected = args.data;
    }
    function WorkItemSelected(args){
        console.log(args);
    }

    function EditWorkItem(args)
    {
        console.log(args);
        window.location.href = ""/Dashboard/EditWorkItem?projectId=");
#nullable restore
#line 243 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Views/Boards/SprintBacklogs.cshtml"
                                                             Write(result);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"&&workItem=""+args.rowData.id
    }
    function load(args) {
        this.parentDetails.parentKeyFieldValue = this.parentDetails.parentRowData['id'];
    }

    function AddNewWorkItem(args)
    {
        console.log(args);
    }

    function dialogClose() {
            document.getElementById('dialogBtn').style.display = 'block';
    }
    function dialogOpen() {
        document.getElementById('dialogBtn').style.display = 'none';
    }

    // Dialog will be closed, while clicking on overlay
    function onChange(args) {
            if(args.checked) {
                dialogObj.overlayClick = function () {
                    dialogObj.hide();
                };
            }
            else {
                dialogObj.overlayClick = function () {
                    dialogObj.show();
                };
            }
        }


        function NewTask(){
            window.location.href = ""/Dashboard/AddNewWorkItem?projectId=""+ProjectId+""&workItemType=""+3+""&boardId=""+boardId+""&parentId=""+selected.id;
   ");
            WriteLiteral(@"     }
        function NewIssue(){
            window.location.href = ""/Dashboard/AddNewWorkItem?projectId=""+ProjectId+""&workItemType=""+6+""&boardId=""+boardId+""&parentId=""+selected.id;
        }
        function NewBug(){
            window.location.href = ""/Dashboard/AddNewWorkItem?projectId=""+ProjectId+""&workItemType=""+1+""&boardId=""+boardId+""&parentId=""+selected.id;
        }
    </script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
