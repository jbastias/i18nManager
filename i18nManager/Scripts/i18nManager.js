function getLanguageList() {
    window.lang = [];
    $("#languageList li > span").each(function () {
        var $this = $(this);
        var lang = $this.text();
        window.lang.push(lang);
    });
}

$(function () {

    $('#languageList a.btn.btn-danger.btn-mini').live('click', function (e) {
        var $this = $(this);
        $this.parent().parent().remove();
    });

    $('#languageList a:not(.btn-danger)').live('click', function (e) {
        alert("'en' cannot be deleted");
    });

    $('#addLanguage').click(function (e) {
        var lang = $("#languages > option:selected").val();
        if (lang == '') return;
        $('#languageList').append('<li><span class="span2">' + lang
                    + '</span><div class="span2"><a href="#" class="btn btn-danger btn-mini"><i class="icon-trash icon-white"></i></a></div></li>');
        $("#languages > option[value='" + lang + "']").remove();
        $("#languages").val('');
    });


    $("#newResourceItem").live('click', function (e) {
        $.post('/project/resx/newresx/' + $('#projectId').val(), { resxName: $('#resourceItemName').val() }, function (result) {
            // console.log(result);
            console.dir(result);
        });

    });


});