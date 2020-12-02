// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    var i = 1;
    $("label").each(function (index) {
        $(this).click(function () {
            console.info("button working");

            var name = $(this).attr("name");
            console.info(name);
            var value = $("#AssignmentTags").val();
            if (value == "")
                $("#AssignmentTags").val(name);
            else
                $("#AssignmentTags").val(value + ", " + name);
        })
    })
    

    
})
