// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
function getnewRandomPass(){
    $.ajax(
        {
            url: 'randompass',
            method: 'POST'
        }).done(function(data){
            
            console.log(data);

            $('#newPassword').html(data.newPassword);
            $('#Count').html(data.count);
        });

    }