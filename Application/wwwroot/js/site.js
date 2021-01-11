// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//document.addEventListener("keydown", (e) => {

//    if (e.ctrlKey && e.key === 'n') {
//        alert("funcionó");
//        e.preventDefault();
//    }
//});
const States = Object.freeze({ Pendiente: 1 , Iniciada: 2});

$(".delete-link").each((index, element) => {
    $(element).click(e => {
        if (element.href) {

            e.preventDefault();

            if (confirm("¿Esta seguro que desea eliminar este registro?")) {
                window.location = element.href;
            }
        }       
   });
});

$(".confirm").submit((e) => {

    e.preventDefault();

    if (confirm("¿Está seguro de continuar con la operación?")) {
        e.target.submit();
    }
});

$('.ui.dropdown').dropdown();
$('.checkbox').checkbox();
$('.menu .item').tab();
