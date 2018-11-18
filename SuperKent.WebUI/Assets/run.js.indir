$(document).ready(function () {
	$('.menu ul li a').click(function () {
		$('.menu ul li a').removeClass("activee");
		$(this).addClass("activee");
	});
});
$(document).ready(function () {
	$('.dilsecenek ul li a').click(function () {
		$('.dilsecenek ul li a').removeClass("active");
		$(this).addClass("active");
	});
});
$(document).ready(function() {
	$('.accordion-headline').on('click',function() {
	  if($(this).hasClass('open')) {
		$(this).removeClass('open').next().slideToggle('fast');
		$('.accordion-content').not($(this).next()).slideUp('fast');
	  } else {
		$('.accordion-headline').removeClass('open');
		$(this).addClass('open').next().slideToggle('fast');
		$('.accordion-content').not($(this).next()).slideUp('fast');
	  }
	});
	});
	
	$('.owl-carousel').owlCarousel({
			loop:true,
			items:1,
			nav:false,
			dots: false,
			autoplay: true,		
			autoplayTimeout:5000,
			responsiveClass:true,
			autoplayHoverPause:true,
		responsive:{
			0:{
				items:1,
			},
			600:{
				items:1,
			},
			1000:{
				items:1,
			}
		}

	});


var owl = $('.owl-carousel');
owl.owlCarousel();
$('.customNextBtn').click(function() {
    owl.trigger('next.owl.carousel');
})
$('.customPrevBtn').click(function() {
    owl.trigger('prev.owl.carousel', [300]);
});



$('.menu-btn').click(function() {

	$('.mobile-menu').toggleClass('open');

	$('.menu-btn').toggleClass('open');

	$('.shadow-mask').toggleClass('open');

	$('body').toggleClass('hidden');



});

$('.shadow-mask').click(function() {

	$('.mobile-menu').removeClass('open');

	$('.menu-btn').removeClass('open');

	$('.shadow-mask').removeClass('open');

	$('body').removeClass('hidden');

});



$(".mobile-menu a").click(function() {

	var target = $(this).attr('hedef');

	$(target).slideToggle(200);

});

$(document).ready(function () {
	$("#form-menu").click(function () {
		$(".form_content").toggleClass("form-open");
		$("#form-menu").toggleClass("menu-open");
	});
});

$(document).ready(function () {
	$("#kapatbtn").click(function () {
		$(".form_content").toggleClass("form-open");
		$("#form-menu").toggleClass("menu-open");
		$(".form_content2").toggleClass("form-open2");
		$("#form-menu2").toggleClass("menu-open2");
	});
});

$(document).ready(function () {
	$("#form-menu2").click(function () {
		$(".form_content2").toggleClass("form-open2");
		$("#form-menu2").toggleClass("menu-open2");
	});
});

$(document).ready(function () {
	$(window).scroll(function () {
		if ($(this).scrollTop() > 50) {
			$('.goto-top').fadeIn();
		} else {
			$('.goto-top').fadeOut();
		}
	});
	$('.goto-top').click(function () {
		$("html, body").animate({
			scrollTop: 0
		}, 600);
		return false;
	});
});



$(function () {
	var width = 200,
		height = 44 * 5 + 20,
		speed = 300,
		button = $('#menu-button'),
		overlay = $('#overlay'),
		menu = $('#hamburger-menu');
	button.on('click', function (e) {
		if (overlay.hasClass('open')) {
			animate_menu('close');
		} else {
			animate_menu('open');
		}
	});
	overlay.on('click', function (e) {
		if (overlay.hasClass('open')) {
			animate_menu('close');
		}
	});
	$('a[href="#"]').on('click', function (e) {
		e.preventDefault();
	});

	function animate_menu(menu_toggle) {
		if (menu_toggle == 'open') {
			overlay.addClass('open');
			button.addClass('on');
			overlay.animate({
				opacity: 1
			}, speed);
			menu.animate({
				width: width,
				height: height
			}, speed);
		}
		if (menu_toggle == 'close') {
			button.removeClass('on');
			overlay.animate({
				opacity: 0
			}, speed);
			overlay.removeClass('open');
			menu.animate({
				width: "0",
				height: 0
			}, speed);
		}
	}
});
$("#map_canvas").click(function () {
	$(".mapping").css("pointer-events", "inherit")
}), $("#map_canvas").mouseleave(function () {
	$(".mapping").css("pointer-events", "none")
})

jQuery(document).ready(function () {
	//$('#frmCeptel').mask("0 (999) 999 99 99");
});


jQuery(document).ready(function () {
	$('.AlphabetsOnly').keypress(function (e) {
		var regex = new RegExp(/^[a-zA-Z\s]+$/);
		var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
		if (regex.test(str)) {
			return true;
		} else {
			e.preventDefault();
			return false;
		}
	});
});

function validate() {
	jQuery("#form1").validationEngine('attach', {
		onValidationComplete: function (form, status) {
			if (status == true) {

				$('#sendMessage').css("display", "none");
				$('#spngonder').css("display", "block");
				$('#form1').submitData();
			}
			else {
				jQuery("#form1").validationEngine('detach');
			}
		},
		autoHidePrompt: true,
		autoHideDelay: 1500,
		promptPosition: "bottomLeft",
		fadeDuration: 0.3
	});
};


function checkHELLO(field, rules, i, options) {
	if (field.val() != "HELLO") {
		return options.allrules.validate2fields.alertText;
	}
}

function checkHELLO(field, rules, i, options) {
	if (field.val() != "HELLO") {
		return options.allrules.validate2fields.alertText;
	}
}

function isCurrency(ch, key) {
	if (!(ch >= '0' && ch <= '9') && key != 8 && key != 44) {
		return false;
	}
	return true;
}

function isTextKey(evt) {
	var charCode = (evt.which) ? evt.which : event.keyCode
	if (charCode > 32 && (charCode < 198 || charCode > 352) && (charCode < 64 || charCode > 223)) return false;
	return true;
}

function getkey(e) {
	if (window.event) return window.event.keyCode;
	else if (e) return e.which;
	else
		return null;
}

function keyCheck(e, obj) {
	var key, ch;
	key = getkey(e);
	if (key == null) return true;
	ch = String.fromCharCode(key);
	if (!isCurrency(ch, key)) {
		if (window.event) window.event.returnValue = false;
		else
			e.preventDefault();
	}
	return true;
}

function NumericOnly(e) {
	var key;
	if (window.event) key = event.keyCode
	else
		key = e.which
	if (key > 47 && key < 58 || key == 8) return;
	else
	if (window.event) window.event.returnValue = null;
	else
		e.preventDefault();
}
