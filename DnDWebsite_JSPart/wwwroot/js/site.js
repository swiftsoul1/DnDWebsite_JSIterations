var uri = "http://www.dnd5eapi.co/api/monsters";
let monsters = null;

$(document).ready(function () {
    getData();
    $("#pressed").text((0));
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
                success: function (data ) {
                }
            }).then(function (data) {
                htmlString = '<tr><td>' + data.name + '</td><td>' + data.challenge_rating +
                    '</td><td><a href="' + data.url + '">link</a></td>' +
                    '<td><button onclick=add('+ data.index + ')>+</button ></td ></tr > ';
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


function add(l) {

    $.ajax({
        type: "GET",
        url: uri + '/' + l,
        cache: false,
        crossDomain: true,
        success: function (data) {
            var k = $("#pressed").text();
            console.log(k);
            document.getElementById("NPCs_" + k + "__Name").value = data.name;
            document.getElementById("NPCs_" + k + "__CR").value = data.challenge_rating;
            document.getElementById("NPCs_" + k + "__Weblink").value = data.url;
            var p = $("#pressed").text();
            p++;
            if (p == 5) {
                p = 0;
            }
            $("#pressed").text(p);
            
        }
    });
    
    
}