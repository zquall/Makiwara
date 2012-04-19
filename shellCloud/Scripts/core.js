$(document).ready(function () {
    bindShowPendingProjects();
});

function bindShowPendingProjects() {
    // Create the dialog
    $('#pending-projects-dialog').dialog({
        height: 140,
        modal: true
    });
    // Bind the click that is going to open the dialog
    $('#pending-projects-button').click(function () {
        $("#pending-projects-dialog").dialog( "open" );
    });
}