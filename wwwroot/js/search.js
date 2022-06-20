$(document).ready(function () {


    $('#search-box').keyup(function () {
        var searchkey = $('#search-box').val();
        $(".search-product").remove();

        $.ajax({
            type: "GET",
            url: "/Home/Search",
            data: { searchkeyWork: searchkey },
            success: function (res) {
                var product = JSON.parse(res);
                if (searchkey.length >= 2 && product.length > 0) {
                    console.log(product);
                    var html_body_search = `
                            <div class="search-product">
                                <ul></ul>
                            </div>
                        `
                } $(".header-search").append(html_body_search);
                $.each(product, function (key, item) {
                    if (searchkey.length >= 2 && product) {

                        var html_search_product_list = `

                                     <li class="search-product-li">
                                        <a>
                                            <div class="search-product-img">
                                                <img src="${item.Product_Img}" />
                                            </div>
                                            <div class="search-product-content">
                                                <h1>
                                                    ${item.Product_Name}
                                                </h1>
                                                <div class="search-product-price">
                                                    <span class="search-product-priceCurrent">${item._Product_Price}đ</span>
                                                    <span class="search-product-priceOld">${item._Product_OldPrice}đ</span>
                                                    <span class="search-product-percent">-${item.Product_DegreePercent}%</span>
                                                </div>
                                            </div>
                                        </a>
                                    </li>
                                `
                        $(".search-product").append(html_search_product_list);
                    }
                });
            }
        })

    })
})