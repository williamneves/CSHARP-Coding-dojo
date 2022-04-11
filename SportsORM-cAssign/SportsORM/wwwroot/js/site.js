// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Attach validation error styling to any input that is invalid
$(".input-validation-error").each(function(){
    $(this).addClass("is-invalid");
});

// Write your JavaScript code.
function renderPartial(partial){

    axios.post(partial)
        .then(res => {

            //console.log(res.data);
            let htmlElement = createHtml(res.data)
            document.getElementById(partial).append(htmlElement)

        })
        .catch(error => {
            console.log(error)
        })
}
function createHtml(data) {
    let htmlElement = document.createElement("div")
    htmlElement.innerHTML = data
    return htmlElement
}

function renderPartialAjax(partial){
    $.when($.ajax(
        {
            url: partial,
            method: 'POST'
        })).done(function(data){
            

            $('#'+partial).html(data);
        });

    }