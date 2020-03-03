function init() {
    $('#sidebarCollapse').on('click', function () {
        $('#sidebar').toggleClass('active');
    });

    $('#dataTable').DataTable();
}

$(function () {
    $('#dataTable').DataTable({
        "pageLength": 3,
        "paging": true,
        "lengthChange": false,
        "searching": false,
        "ordering": true,
        "info": true,
        "autoWidth": false
    });
});
 
$(document).ready(function () {
    init();



});