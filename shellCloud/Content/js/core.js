$(document).ready(function () {
    bindShowPendingProjects();
});

function bindShowPendingProjects() {
    // Create the dialog
    $('#pending-projects-dialog').dialog({
        height: 140,
        modal: true,
        autoOpen: false,
        title: "Proyectos Activos",
        resizable: false,
        buttons: {
            "Seleccionar Proyecto": function () {
                $.ajax({
                    url: '@Url.Action("foo")',
                    type: 'POST',
                    async: true,
                    data: { name: 'john', age: 20 },
                    success: function (result) {
                        // TODO:
                    }
                });
            },
            Cancel: function () {
                $(this).dialog("close");
            }
        }
    });
    // Bind the click that is going to open the dialog
    $('#pending-projects-button').click(function () {
        $("#pending-projects-dialog").dialog( "open" );
    });
    
}
