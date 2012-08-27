$.fn.nav_dropdown = function (options) {

    var defaults = {};
    var opts = $.extend(defaults, options);

    // Apply class=hasChildren on those items with children
    this.each(function () {
        $(this).find('li').each(function () {
            if ($(this).find("ul").length > 0) {
                $(this).addClass("hasChildren");
                $(this).find('> a').wrapInner("<span></span>");
            }
        });
    });

    // Apply class=hover on all list items
    $(this).find("li").hover(function () {
        $(this).addClass('hover');
    }, function () {
        $(this).removeClass('hover');
    });

    $('li').has('ul').hover(function () {
        $(this).children('ul').show();

    }, function () {
        $(this).children('ul').hide();
    });
};


/* On DOM Ready */
$(function () {

    $('nav').nav_dropdown();

}); 