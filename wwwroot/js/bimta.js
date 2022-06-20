//slide price
const range = document.querySelectorAll(".range-slider span input");
progress = document.querySelector(".range-slider .progress");
let gap = 0.1;
const inputValue = document.querySelectorAll(".numberVal input");

range.forEach((input) => {
    input.addEventListener("input", (e) => {
        let minRange = parseInt(range[0].value);
        let maxRange = parseInt(range[1].value);

        if (maxRange - minRange < gap) {
            if (e.target.className === "range-min") {
                range[0].value = maxRange - gap;
            } else {
                range[1].value = minRange + gap;
            }
        } else {
            progress.style.left = (minRange / range[0].max) * 100 + "%";
            progress.style.right = 100 - (maxRange / range[1].max) * 100 + "%";
            inputValue[0].value = minRange;
            inputValue[1].value = maxRange;
        }
    });
});







$('.filter-item.filter-hang').click(function () {
    $('.filter-item.filter-hang').toggleClass("active")
    $('.filter-item.filter-hang .filter-show').toggleClass("active");

})



$('.filter-item.filter-price').click(function () {
    $('.filter-item.filter-price').toggleClass("active")
    $('.filter-item.filter-price .filter-show').toggleClass("active");

})

//$('.filter-item.filter-type').click(function () {
//    $('.filter-item.filter-type').toggleClass("active")
//    $('.filter-item.filter-type .filter-show').toggleClass("active");

//})

$('.filter-item.filter-weight').click(function () {
    $('.filter-item.filter-weight').toggleClass("active")
    $('.filter-item.filter-weight .filter-show').toggleClass("active");

})

$('.filter-item.filter-size').click(function () {
    $('.filter-item.filter-size').toggleClass("active")
    $('.filter-item.filter-size .filter-show').toggleClass("active");

})




var filtersBrand = [];
var filtersType = [];
var filtersSize = [];
var sortSelected = "";
var prd = {
    Product_trademark: [],
    Product_type: [],
    Product_size: [],
    orderType: ""
};


//$('.filter-item.filter-main').click(function () {
//    $('.filter-item.filter-main').toggleClass("active")
//    $('.filter-item.filter-main .filter-show').toggleClass("active");

//})
function showFilterItem(obj) {
    var id = document.getElementById("filter-type");

    if (id.style.display == "block") {
        id.style.display = "none";
    }
    else {
        id.style.display = "block";
    }
}

//sort
function showFilterItem1(obj) {
    var id = document.getElementById("sort-main");
    console.log(id);
    if (id.style.display == "block") {
        id.style.display = "none";
    }
    else {
        id.style.display = "block";
    }
}




// sort filter
$(document).ready(function () {
    $('.sort').click(function () {
        prd.orderType = $(this).attr('data-name');
        console.log(prd.orderType)
        var myJsonProduct = JSON.stringify(prd);

        $.ajax({
            url: '/BimTa/OrderFilter',
            type: 'GET',
            data: {
                jsonprd: myJsonProduct
            },
            dataType: 'json',
            contentType: 'application/json;charset=utf-8',
            success: function (response) {
                var data = JSON.parse(response);
                $('#list_bimta_grid').load('/BimTa/LoadBimTa', {
                    BimTaList: data,
                });
            },
            error: function () {
            }
        })
    })
});


//click add item, add class active
$(document).ready(function () {
    $('.c-btnbox').click(function () {
        if ($(this).hasClass('active')) {

            if (filtersBrand.includes($(this).attr('data-brand'))) {
                filtersBrand.pop($(this).attr('data-brand'));
            }
            if (filtersType.includes($(this).attr('data-type'))) {
                filtersType.pop($(this).attr('data-type'));
            }
            if (filtersSize.includes($(this).attr('data-size'))) {
                filtersSize.pop($(this).attr('data-size'));
            }
            $(this).removeClass('active');
            console.log("removed " + filtersBrand);
            console.log("removed " + filtersType);
            console.log("removed " + filtersSize);
        }
        else {
            if ($(this).attr('data-brand') != undefined && !filtersBrand.includes($(this).attr('data-brand'))) {
                filtersBrand.push($(this).attr('data-brand'));
            }
            if ($(this).attr('data-type') != undefined && !filtersType.includes($(this).attr('data-type'))) {
                filtersType.push($(this).attr('data-type'));
            }
            if ($(this).attr('data-size') != undefined && !filtersSize.includes($(this).attr('data-size'))) {
                filtersSize.push($(this).attr('data-size'));
            }
            $(this).addClass('active');
            console.log("added " + filtersBrand);
            console.log("added " + filtersType);
            console.log("added " + filtersSize);
        }
    })
});


$(document).ready(function () {
    $('.btn-filter-readmore').click(function () {
        prd.Product_trademark = filtersBrand;
        prd.Product_type = filtersType;
        prd.Product_size = filtersSize;
        console.log(prd);

        var myJsonProduct = JSON.stringify(prd);

        $.ajax({
            url: '/BimTa/SearchFilter',
            type: 'GET',
            data: {
                jsonprd: myJsonProduct
            },
            dataType: 'json',
            contentType: 'application/json;charset=utf-8',
            success: function (response) {
                console.log(response);
                var data = JSON.parse(response);
                $('#list_bimta_grid').load('/BimTa/LoadBimTa', {
                    BimTaList: data,
                });
            },
            error: function () {
            }
        })
    })
});


