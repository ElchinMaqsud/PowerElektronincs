    $(document).ready(function(){
let responsiveIcon= document.querySelector(".header-icon i");
let responsiveCloseIcon=document.querySelector(".responsive-close-icon i")
let body= document.querySelector("body");
responsiveIcon.addEventListener("click",function(e){
     
        e.preventDefault();
     $(".responsive-navbar").toggle("drop",true,100);
     $(".responsive-navbar").addClass("d-block");
     $(".responsive-close-icon").removeClass("d-none");
     $(".responsive-close-icon").addClass("d-block");
     $(".header-icon").removeClass("d-block");
       $('.header-icon').addClass('d-none');
       $('body').css('overflow','hidden');
      
     
       
    });
responsiveCloseIcon.addEventListener("click",function(e){
    e.preventDefault();
    $(".responsive-navbar").removeClass("d-block");
    $(".responsive-navbar").addClass("d-none");
    $('.header-icon').removeClass('d-none');
    $('.header-icon').addClass('d-block');
    $(".responsive-close-icon").removeClass("d-block");
       $(".responsive-close-icon").addClass("d-none");
       $('body').css('overflow','visible');
})
$(document).on("click",".like-icon",function(){
    $(this).toggleClass("active");
})

let phoneMainImage= $("#phoneDetails .phone-ads-main-image img");
let selectedImageDiv=$("#phoneDetails .phone-zoom-img");
let selectedImage= $("#phoneDetails .phone-zoom-img .phone-img img");

$(document).on("click","#phoneDetails .phone-ads-main-image img",function(){
    selectedImageDiv.removeClass("d-none");
    selectedImageDiv.addClass("d-flex","justify-content-center","align-items-center");
    
    let mainImageSrc=phoneMainImage.attr("src");
    selectedImage.attr("src",mainImageSrc);
    $('body').css('overflow','hidden');
})

$(document).on("click","#phoneDetails .phone-ads-image img",function(){

    selectedImageDiv.removeClass("d-none");
    selectedImageDiv.addClass("d-flex","justify-content-center","align-items-center");
   let  selectedImageSrc=$(this).attr("src");
    selectedImage.attr("src",selectedImageSrc);
});



$(document).on("click","#phoneDetails .phone-zoom-img .phone-img .image-close",function(){
    selectedImageDiv.removeClass("d-flex","justify-content-center","align-items-center");
    selectedImageDiv.addClass("d-none");
    $('body').css('overflow','visible');
})


$(document).on("click","#adsEdit .phone-ads-main-image img",function(){
    let selectedImageDivAds=$("#adsEdit .phone-zoom-img");
    let selectedImageAds=$("#adsEdit .phone-zoom-img .phone-img img");
    let phoneMainImage= $("#adsEdit .phone-ads-main-image img");

    selectedImageDivAds.removeClass("d-none");
    selectedImageDivAds.addClass("d-flex","justify-content-center","align-items-center");
    let mainImageSrc=phoneMainImage.attr("src");
    selectedImageAds.attr("src",mainImageSrc);
    $('body').css('overflow','hidden');
})
$(document).on("click","#adsEdit .phone-ads-image img",function(){
    let selectedImageDivAds=$("#adsEdit .phone-zoom-img");
    let selectedImageAds=$("#adsEdit .phone-zoom-img .phone-img img");

    selectedImageDivAds.removeClass("d-none");
    selectedImageDivAds.addClass("d-flex","justify-content-center","align-items-center");
   let  selectedImageSrc=$(this).attr("src");
   selectedImageAds.attr("src",selectedImageSrc);
});
$(document).on("click","#adsEdit .phone-zoom-img .phone-img .image-close",function(){
    let selectedImageDivAds=$("#adsEdit .phone-zoom-img");
    selectedImageDivAds.removeClass("d-flex","justify-content-center","align-items-center");
    selectedImageDivAds.addClass("d-none");
    $('body').css('overflow','visible');
})
$(document).on("click",".ads-fake-input-div",function(){
    $(this).prev().click();
})
$(document).on("click",".ads-fakt-input-images-div",function(){
    $(this).prev().click();
})
$(document).on("click",".edit-imageFakeDiv",function(){
    $(this).prev().click();
})
$(document).on("click",".create-imageFakeDiv",function(){
    $(this).prev().click();
})

        $(document).on('click', '.user-profile-img-div i', function () {
            $(this).parent().remove();

        $.ajax({
            url: '/Account/DeleteUserPhoto',
            method: 'DELETE',
            success: function (result) {
                console.log(result);
            },
            error: function (result) {
                
            }
        });
    });





    $(document).ready(function () {

        $(document).on("change", ".ads-product-category-for-create-ads", function () {
        var categoryId = $(this).val();
        if (categoryId) {
            $.ajax({
                url: "/Ajax/SelectMarks?id=" + categoryId,
                type: "get",
                success: function (res) {
                    $(".ads-product-mark-for-create-ads").html(res);
                }
            })
        }
         });

        $(document).on("change", ".ads-product-mark-for-create-ads", function () {
            var MarkId = $(this).val();
            if (MarkId) {
                $.ajax({
                    url: "/Ajax/SelectModels?id=" + MarkId,
                    type: "get",
                    success: function (res) {
                        $(".ads-product-model-for-create-ads").html("");

                        $(".ads-product-model-for-create-ads").append(res);

                    }
                })
            }
        });




    });


       
    });









$(document).ready(function () {
    let userProfileImg = document.querySelector("#userProfileImg");
    if (userProfileImg.getAttribute("src") == "/userImages/noImage.png") {
        $(userProfileImg).next().addClass("d-none");
    }
});
$(document).ready(function () {
    let deleteBtn = document.querySelector("#userProfileImg i");
    $(document).on("click", deleteBtn, function () {
        $(this).parent().remove();
    })
})

