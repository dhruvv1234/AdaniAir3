jQuery(document).ready(function($) {
    function checkWidth() {
        var windowSize = jQuery(window).width();

        if (windowSize > 1199.98) {
            jQuery(".headerSection .nav-item").hover(
                function () {
                    jQuery(this).parents(".headerSection").addClass("megaMenuOpen");
                }, function () {
                    jQuery(this).parents(".headerSection").removeClass("megaMenuOpen");
                });
                jQuery(".headerSection .nav-item.dropMenuOpen").hover(
                function () {
                    jQuery(this).parents(".headerSection").addClass("openDrop");
                }, function () {
                    jQuery(this).parents(".headerSection").removeClass("openDrop");
                });  

                (function($) {
                    $(document).scroll(function() {
                        var $nav = $(".headerSection");
                        $nav.toggleClass('scrolled', $(this).scrollTop() > 20);
                    });
                })(jQuery);
                  
        }

        if (windowSize < 991) {
            
            
         }
      
    }

    // Execute on load
    checkWidth();
    // Bind event listener
    jQuery(window).resize(checkWidth);
});

if(window.innerWidth > 991){
    
}
jQuery(document).on('click',".mobileSearch",function(){
    jQuery(this).toggleClass('menuSearchOpen');
    jQuery(".headerSection .rightNavMenu li.searchMenu .megaMenu").toggleClass("show");
    jQuery("header").toggleClass("showMobileSearch");
    jQuery("body").toggleClass("overflow-hidden");
    jQuery(".navbar-collapse").removeClass("show");
    jQuery(".megaMenu").removeClass("showMenu");
    jQuery(".navbar-nav").removeClass("showMenu");
    jQuery(".navbar-toggler").removeClass('menuOpen');
    jQuery("header").removeClass("show-header");
});

jQuery(document).on('click',".navbar-toggler",function(){
    jQuery(".navbar-collapse").toggleClass("show");
    jQuery(this).toggleClass('menuOpen');
    jQuery("header").toggleClass("show-header");
    jQuery("body").toggleClass("overflow-hidden");
    jQuery(".mobileSearch").removeClass('menuSearchOpen');
    jQuery("header").removeClass("showMobileSearch");
});
jQuery(document).on('click',".closeMenu",function(){
    jQuery(".navbar-collapse").removeClass("show");
    jQuery(".megaMenu").removeClass("showMenu");
    jQuery(".navbar-nav").removeClass("showMenu");
});

// mobile sub menu
jQuery(document).on('click',".nav-item",function(){
    jQuery(this).find(".dropMenu").toggleClass("openArrow");
    jQuery(this).find(".megaMenu").toggleClass("showMenu");
    jQuery(this).siblings().find(".megaMenu").removeClass("showMenu")
    jQuery(".nav-item").not(this).find(".dropMenu").removeClass("openArrow");
    jQuery(this).parents(".navbar-nav").toggleClass("showMenu");
});

// Footer Script
jQuery(".footerSection .footerInner .footerMenuBlock h5").click(function(){
    jQuery(".footerSection .footerInner .footerMenuBlock ul").hide();
    jQuery(this).next("ul").slideToggle();
});
