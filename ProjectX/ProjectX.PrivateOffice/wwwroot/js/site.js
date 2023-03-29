$(".dropdown-menu li a").click(function (e) {
    var id = $(e.currentTarget).data('id');
    var selText = $(this).text();
    var dropdown = $(this).parents('.dropdown').find('.dropdown-toggle');
    dropdown.html(selText);
    $(dropdown).attr('data-id', id);
});
