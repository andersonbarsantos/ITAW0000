function init() {
    $('#sidebarCollapse').on('click', function () {
        $('#sidebar').toggleClass('active');        
    });
  };


$(document).ready(function () {
    init(); 
});
