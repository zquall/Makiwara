$(document).ready(function () {
    createPendingProjectsDialog();
});

function createPendingProjectsDialog() {
    // Create the dialog
    $('#pending-projects-dialog').dialog({
        height: 'auto',
        width: 450,
        modal: true,
        autoOpen: false,
        title: 'Proyectos Activos',
        resizable: false,
        open: function (event, ui) {
            $("#active-projects").empty();
            loadPendingProjects();
        },
        buttons: {
            'Seleccionar Proyecto': function () {
                //var projectCode = $('.ui-selected').find('.project-code').text();
            },
            Cancel: function () {
                $(this).dialog('close');
            }
        }
    });
    // Bind the click that is going to open the dialog
    $('#pending-projects-button').click(function () {
        $("#pending-projects-dialog").dialog( 'open' );
    });
}

function loadPendingProjects () {
    $.ajax({
        url: 'project/GetActiveProjects',
        type: 'GET',
        async: true,
        success: function (result) {
            if (result.ProjectList.length > 0) {
                var dialogContent = $("#active-projects");
                $(result.ProjectList).each(function (index, value) {
                    dialogContent.append('<li class="selectable-content"><div class="project-code">' + value.Code + '</div><span>' + value.Name + '</span></li>');
                });
                dialogContent.selectable();
            }
        }
    });
}