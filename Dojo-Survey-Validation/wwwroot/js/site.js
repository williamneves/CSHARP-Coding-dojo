// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
async function generate() {
        // The await keyword lets js know that it needs to wait until it gets a response back to continue.
        var response = await fetch("randompass");
        // We then need to convert the data into JSON format.
        var coderData = await response.json();
        return coderData;
}
