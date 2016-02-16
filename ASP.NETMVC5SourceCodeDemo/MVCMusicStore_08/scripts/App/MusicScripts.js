$(function () {
    $("#album-list li div").mouseover(function() {
        animateElement($(this));
    });
 

    $("#album-list2 li div").mouseover(function() {
       // $(this).effect("bounce");
        $(this).effect("bounce", {time:10,distance:20});
    });
    $("#album-list li div,#album-list2 li div").hover(function () {
        $(this).toggleClass("highlight");
    });


    //*********************************
    $("input[data-autocomplete-source]").each(function() {
        var target = $(this);
        target.autocomplete({ source: target.attr("data-autocomplete-source") });
    });

    $("#QuickSearch").submit(function (event) {
        
        event.preventDefault();
        var form = $(this);
        // $("#searchresults").load(form.attr("action"), form.serialize());
        //$.getJSON(form.arrt("action"),form.serialize(), function(data) {
        //    var html = Mustache.to_html($("#artistTemplate").html(), { artitsts: data });
        //    $("#searchresults").empty().append(html);
        //});

        $.ajax({
            url: form.attr("action"),
            data: from.serialize(),
            beforeSend: function() {
                $("#ajax-loader").show();
            },
            complete: function() {
                $("#ajax-loader").hide();
            },
            error: searchFailed,
            success: function(data) {
                alert(data);
            }
        });
    });
});

function animateElement(element) {
    element.animate({ height: '+=25', width: '+=25' }).animate({ height: '-=25', width: '-=25' });
}

//查询失败执行的函数
function searchFailed() {
    $("#searchresults").html("sorry,there was a problem with the search.");
}