let elements = document.querySelectorAll('.ans-marks');

elements.forEach(elem => {
    elem.addEventListener('click', (e) => {
        e.preventDefault();
        let dataId = elem.getAttribute('data-id');
        let anouncementSec = document.getElementById('announcement_tabs');
        $.ajax({
            url: `/home/tabloader?id=${dataId}`,
            method: 'get',
            success: function (res) {
                anouncementSec.innerHTML= res
            }
        });
    });
});

elements.forEach(elem => {
    elem.addEventListener('click', (e) => {
        e.preventDefault();
        let dataId = elem.getAttribute('data-id');
        let anouncementSec = document.getElementById('announcement_smartphones');
        $.ajax({
            url: `/home/smartphoneloader?id=${dataId}`,
            method: 'get',
            success: function (res) {
                anouncementSec.innerHTML = res
            }
        });
    });
});

elements.forEach(elem => {
    elem.addEventListener('click', (e) => {
        e.preventDefault();
        let dataId = elem.getAttribute('data-id');
        let anouncementSec = document.getElementById('announcement_laptops');
        $.ajax({
            url: `/home/laptoploader?id=${dataId}`,
            method: 'get',
            success: function (res) {
                anouncementSec.innerHTML = res
            }
        });
    });
});

elements.forEach(elem => {
    elem.addEventListener('click', (e) => {
        e.preventDefault();
        let dataId = elem.getAttribute('data-id');
        let anouncementSec = document.getElementById('announcement_tvies');
        $.ajax({
            url: `/home/tvloader?id=${dataId}`,
            method: 'get',
            success: function (res) {
                anouncementSec.innerHTML = res
            }
        });
    });
});

elements.forEach(elem => {
    elem.addEventListener('click', (e) => {
        e.preventDefault();
        let dataId = elem.getAttribute('data-id');
        let anouncementSec = document.getElementById('announcement_smartwatches');
        $.ajax({
            url: `/home/smartwatchloader?id=${dataId}`,
            method: 'get',
            success: function (res) {
                anouncementSec.innerHTML = res
            }
        });
    });
});

$(document).ready(function () {

    $(document).on("click", "#deleteAdsImg", function (e) {
        e.preventDefault();
        $(this).parent().remove();
        var ImageId = $(this).attr("data-id");

        if (ImageId) {
            $.ajax({
                url: "/Ajax/DeleteAdsImage?ImageId=" + ImageId,
                type: "GET",
            });
        }

    })
})

$(document).ready(function () {

    $(document).on("click", "#loadMoreBtn", function () {
        let Skipcount = parseInt($("#loadMoreCount").val());
        if (Skipcount) {
            $.ajax({
                url: "/Ajax/LoadMoreAds?SkipCount=" + Skipcount,
                type: "GET",
                success: function (res) {
                    $("#mainAdvertisements").append(res);
                    Skipcount += 6;
                    $("#loadMoreCount").val(Skipcount);
                    if (Skipcount >= $("#allAdsCount").val()) {
                        $("#loadMoreBtn").remove();
                    }


                }

            });


            
        }

    });
    
  
    
});

$(document).ready(function () {
    $(document).on("click", "#searchAdvertisement", function (e) {
        e.preventDefault();
        let categoryId = $(".search-category-select").val();
        let markId = $(".search-mark-select").val();
        let modelId = $(".search-model-select").val();
        let price = $(".search-price-input").val();
        $.ajax({
            url: "/Ajax/SearchAds?CategoryId=" + categoryId + "&MarkId=" + markId + "&ModelId=" + modelId + "&Price=" + price,
            type: "GET",
            success: function (res) {
                $("#mainAdvertisements").html("");
                $("#loadMoreBtn").remove();
                $("#mainAdvertisements").append(res);

            }

        });
    })
});

$(document).ready(function () {

    $(document).on("click", "#loadMoreNews", function () {
        let skipCount = parseInt($("#NewsCount").val());
        if (skipCount) {
            $.ajax({
                url: "/Ajax/LoadMoreInfo?skipCount=" + skipCount,
                type: "GET",
                success: function (res) {
                    $("#NewsDiv").append(res);
                    skipCount += 6;
                    $("#NewsCount").val(skipCount);
                    if (skipCount >= $("#allNewsCount").val()) {
                        $("#loadMoreNews").remove();
                    }


                }

            });



        }

    });



});






