﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var uri = "http://www.dnd5eapi.co/api/monsters";
let monsters = null;

$(document).ready(function () {
    getData();
});

function getData() {
    $.ajax({
        type: "GET",
        url: uri,
        cache: false,
        crossDomain: true,
        success: function (data) {
            resultData = data
        }
    }).then(function (data) {
        const tBody = $("#monsters");
        tBody.empty();
        let htmlString = "";
        let count = data.count;
        $("#total").text(count);
        let loaded = 0;
        let i = 1;
        while (i <= count) {
            $.ajax({
                type: "GET",
                url: uri + '/' + i,
                cache: false,
                crossDomain: true,
                success: function (data) {
                }
            }).then(function (data) {
                htmlString = '<tr><td>' + data.name + '</td><td>' + data.challenge_rating +
                    '</td><td><a href="' + data.url + '">link</a></td>' +
                    '<td><button onclick=add(' + data.name + ',' + data.challenge_rating + ')>+</button ></td ></tr > ';
                tBody.append($.parseHTML(htmlString));
                loaded++;
                $("#loadedTotal").text("Loaded: " + loaded + "/");
                if (loaded === count) {
                    $("#loadedTotal").text("All " + count + " loaded.");
                    $("#total").text("");
                }
            })
            i++;
        }
    }
    );
}