
$(document).ready(function () {
    $("#btn_guardar").on("click", function () {
        if ($("#txt_nombre").val() == "") {
            alert("nombre requerido");
            return false;
        }
        else {
            return true;
        }
    })
})

function guardarCategoria() {
    
}
function setURLRoot(urlBase) {
    urlBaseApp = urlBase;
    //console.log(urlBaseApp);
}
function getURLRoot() {
    return urlBaseApp;
}