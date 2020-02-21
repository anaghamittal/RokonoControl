#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Dashboard/AddNewProject.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc60c1051fe20ce3487a9eb42c9461f4e888e183"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_AddNewProject), @"mvc.1.0.view", @"/Views/Dashboard/AddNewProject.cshtml")]
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
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/_ViewImports.cshtml"
using Rokono_Control;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/_ViewImports.cshtml"
using Rokono_Control.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc60c1051fe20ce3487a9eb42c9461f4e888e183", @"/Views/Dashboard/AddNewProject.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_AddNewProject : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<link href=""https://cdn.syncfusion.com/ej2/ej2-base/styles/material.css"" rel=""stylesheet"" type=""text/css"" />
<link href=""https://cdn.syncfusion.com/ej2/ej2-layouts/styles/material.css"" rel=""stylesheet"" type=""text/css"" />
<style>
    .e-card {
        margin-bottom: 2%;
    }
</style>
<div class=""container-fluid"">

    <div tabindex=""0"" class=""e-card"" id=""Pd"">
        <div class=""e-card-header"">
            <div class=""e-card-header-caption"">
                <div class=""e-card-header-title"">Project Details</div>
            </div>
        </div>
        <div class=""e-card-content"">
            <div class=""row"">
                <div class="" form-group"" style=""width:100%"">
                    <label for=""ProjectName"">Project Name</label>
                    <input name=""ProjectName"" id=""ProjectName"" placeholder=""Project Name"" style=""width:100%"" class=""form-control-sm"">
                </div>
            </div>
        </div>
    </div>
    <div tabindex=""1"" class=""e-card"" id=""Summary"">
        <div class=""e-ca");
            WriteLiteral(@"rd-header"">
            <div class=""e-card-header-caption"">
                <div class=""e-card-header-title"">Quick summary</div>
            </div>
        </div>
        <div class=""e-card-content"">
            <div class=""row"">
                <div class=""position-relative form-group"" style=""width:100%;""><label for=""RepoSteps""");
            BeginWriteAttribute("class", " class=\"", 1474, "\"", 1482, 0);
            EndWriteAttribute();
            WriteLiteral(@">Description</label><textarea name=""RepoSteps"" id=""RepoSteps"" class=""form-control""></textarea></div>
            </div>
        </div>
    </div>
    <div tabindex=""2"" class=""e-card"" id=""PS"">
        <div class=""e-card-header"">
            <div class=""e-card-header-caption"">
                <div class=""e-card-header-title"">Project Settings</div>
            </div>
        </div>
        <div class=""e-card-content"">
            <div class=""row"">
                <div class=""col-md-6"">
                    <p class=""text-center""> Iteration Settings</p>
                    <div class=""content-wrapper"">
                        <div id=""Grid""></div>
                    </div>
                </div>
                <div class=""col-md-6"">
                    <p class=""text-center""> Assign Iterations. You can rename all Iterations and add more if the default doesn't suit your workflow.</p>
                    <div class=""content-wrapper"">
                        <div class=""row"">
                            <div>
     ");
            WriteLiteral(@"                           <label for=""WorkItemOption"" style=""padding:2%; min-width:303px;""> Add/Edit Work Items</label>
                                <input id=""WorkItemOption"" type=""checkbox"" />
                            </div>
                        </div>
                        <div class=""row"">
                            <div>
                                <label for=""ChatChannels"" style=""padding:2%; min-width:303px;"">Create Chat Channels</label>
                                <input id=""ChatChannels"" type=""checkbox"" />
                            </div>
                        </div>
                        <div class=""row"">
                            <div>
                                <label for=""EditUserRights"" style=""padding:2%; min-width:303px;"">Manage other user rights</label>
                                <input id=""EditUserRights"" type=""checkbox"" />
                            </div>
                        </div>
                        <div class=""row"">
                         ");
            WriteLiteral(@"   <div>
                                <label for=""IterationOptions"" style=""padding:2%; min-width:303px;""> Manage Project Iterations</label>
                                <input id=""IterationOptions"" type=""checkbox"" />
                            </div>
                        </div>
                        <div class=""row"">
                            <div>
                                <label for=""ScheduleManagement"" style=""padding:2%; min-width:303px;"">Manage user work days</label>
                                <input id=""ScheduleManagement"" type=""checkbox"" />
                            </div>
                        </div>
                        <div class=""row"">
                            <div>
                                <label for=""ViewWorkItems"" style=""padding: 2%; min-width:303px;"">View other people work items</label>
                                <input id=""ViewWorkItems"" type=""checkbox"" />
                            </div>
                        </div>
                        <di");
            WriteLiteral(@"v class=""row"">
                            <button id=""outlinebtn"" onclick=""AddSelectedUser()"">Add selected user and this these project rights.</button>

                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>

    <div tabindex=""4"" class=""e-card"" id=""IS"">
        <div class=""e-card-header"">
            <div class=""e-card-header-caption"">
                <div class=""e-card-header-title"">Project Settings</div>
            </div>
        </div>
        <div class=""e-card-content"">
            <div class=""row"">
                <p class=""text-center"">Users added to your new project</p>
                <div class=""content-wrapper"">
                    <div id=""GridSelectedUsers""></div>
                </div>

            </div>

        </div>
    </div>

    <div tabindex=""3"" class=""e-card"" id=""Iss"">
        <div class=""e-card-header"">
            <div class=""e-card-header-caption"">
                <div class=""e-card-header-title"">Project Sett");
            WriteLiteral(@"ings</div>
            </div>
        </div>
        <div class=""e-card-content"">
            <div class=""row"">
                <p class=""text-center""> Assign Iterations. You can rename all Iterations and add more if the default doesn't suit your workflow.</p>
                <div class=""content-wrapper"">
                    <div id=""GridIterations""></div>
                </div>

            </div>

        </div>
    </div>


    <div tabindex=""3"" class=""e-card"" id=""Iss"">
        <div class=""e-card-header"">
            <div class=""e-card-header-caption"">
                <div class=""e-card-header-title"">Project Settings</div>
            </div>
        </div>
        <div class=""e-card-content"">
            <div class=""row"">
                <p class=""text-center""> Assign Iterations. You can rename all Iterations and add more if the default doesn't suit your workflow.</p>
                <div class=""content-wrapper"">
                    <button id=""outlinebtn"" onclick=""CreateNewProject()"">Create new project</b");
            WriteLiteral(@"utton>
                </div>

            </div>

        </div>
    </div>


</div>




<script>
    var ActiveUsersGrid;
    var grid;
    var GridIterations;
    var WorkItemOption;
    var ChatChannels;
    var EditUserRights;
    var IterationOptions;
    var ScheduleManagement;
    var ViewWorkItems;
    var CurrentSelected;
    $(document).ready(function () {

        var outlinebtn = new ej.buttons.Button({ cssClass: 'e-outline', isPrimary: true });
        outlinebtn.appendTo('#outlinebtn');
        WorkItemOption = new ejs.buttons.Switch({ checked: true });
        WorkItemOption.appendTo('#WorkItemOption');
        ChatChannels = new ejs.buttons.Switch({ checked: true });
        ChatChannels.appendTo('#ChatChannels');
        EditUserRights = new ejs.buttons.Switch({ checked: true });
        EditUserRights.appendTo('#EditUserRights');
        IterationOptions = new ejs.buttons.Switch({ checked: true });
        IterationOptions.appendTo('#IterationOptions');
        ScheduleManagement = new ejs.");
            WriteLiteral(@"buttons.Switch({ checked: true });
        ScheduleManagement.appendTo('#ScheduleManagement');
        ViewWorkItems = new ejs.buttons.Switch({ checked: true });
        ViewWorkItems.appendTo('#ViewWorkItems');


        $.ajax({
            type: 'GET',
            url: '/Authenication/GetUsers',
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (response) {
                LoadAccounts(response);
            },
            error: function (xhr, status, error) {

            }
        });


        $.ajax({
            type: 'GET',
            url: '/Authenication/GetNewProjectIterationns',
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (response) {
                LoadIterations(response);
            },
            error: function (xhr, status, error) {

            }
        });
        $.ajax({
            type: 'GET',
            url: '/Authenication/GetAvtiveUs");
            WriteLiteral(@"ers',
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (response) {
                LoadActiveUsers(response);
            },
            error: function (xhr, status, error) {

            }
        });
    });

    function LoadIterations(data) {
        GridIterations = new ej.grids.Grid({
            dataSource: data,
            allowPaging: true,
            editSettings: { allowEditing: true, allowAdding: true, allowDeleting: true, mode: 'Normal', newRowPosition: 'Top' },
            toolbar: ['Add', 'Edit', 'Delete', 'Update', 'Cancel'],
            allowSelection: true,
            enableHover: false,
            columns: [
                { field: 'iterationName', headerText: 'Name', width: 180 },

            ],
            pageSettings: { pageCount: 2 }
        });
        GridIterations.appendTo('#GridIterations');
    }


    function LoadActiveUsers(data) {
        ActiveUsersGrid = new ej.grids.Grid({
            dataSource");
            WriteLiteral(@": data,
            allowPaging: true,
            editSettings: { allowEditing: true, allowAdding: true, allowDeleting: true, mode: 'Normal', newRowPosition: 'Top' },
            toolbar: ['Delete', 'Cancel'],
            allowSelection: true,
            enableHover: false,

            pageSettings: { pageCount: 2 }
        });
        ActiveUsersGrid.appendTo('#GridSelectedUsers');
    }
    function LoadAccounts(data) {

        grid = new ej.grids.Grid({
            dataSource: data,
            allowPaging: true,
            rowSelected: AccountSelected,
            allowSelection: true,
            editSettings: { allowDeleting: true },
            enableHover: false,
            columns: [
                { field: 'name', headerText: 'Name', width: 180 },

            ],
            pageSettings: { pageCount: 2 }
        });
        grid.appendTo('#Grid');
    }

    function CreateNewProject() {

        console.log(""in"");
        var dto = {
            ""ProjectName"": $(""#ProjectName"").val(),
     ");
            WriteLiteral(@"       ""ProjectDescription"": $(""#RepoSteps"").val(),
            ""Users"": ActiveUsersGrid.dataSource,// get the selected records.
            ""Iterations"": GridIterations.dataSource
        }
        $.ajax({
            type: 'POST',
            url: '/Dashboard/AddNewProject',
            data: JSON.stringify(dto),
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (response) {
                window.location.href = ""/Dashboard/Index"";
            },
            error: function (xhr, status, error) {
                console.log(error);
            }
        });
    }

    function AddSelectedUser() {
        if (WorkItemOption.properties.checked === true)
            CurrentSelected.workItemOption = 1;
        else
            CurrentSelected.workItemOption = 0;
        if (ChatChannels.properties.checked === true)
            CurrentSelected.chatChannels = 1;
        else
            CurrentSelected.chatChannels = 0;
        if (EditUserRi");
            WriteLiteral(@"ghts.properties.checked === true)
            CurrentSelected.editUserRights = 1;
        else
            CurrentSelected.editUserRights = 0;
        if (IterationOptions.properties.checked === true)
            CurrentSelected.iterationOptions = 1;
        else
            CurrentSelected.iterationOptions = 0;
        if (ScheduleManagement.properties.checked === true)
            CurrentSelected.scheduleManagement = 1;
        else
            CurrentSelected.scheduleManagement = 0;
        if (ViewWorkItems.properties.checked === true)
            CurrentSelected.viewWorkItems = 1;
        else
            CurrentSelected.viewWorkItems = 0;

        ActiveUsersGrid.addRecord(CurrentSelected);
        ActiveUsersGrid.refresh(); // refresh the Grid.
    }

    function AccountSelected(args) {
        console.log(args);
        console.log(GridIterations.getRows());
        CurrentSelected = args.data;
        console.log(WorkItemOption.properties.checked);

    }


</script>");
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
