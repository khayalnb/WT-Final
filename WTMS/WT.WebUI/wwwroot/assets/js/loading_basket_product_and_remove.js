$(document).ready(function () {
    load();
    function load() {
        const products = JSON.parse(localStorage.getItem("basketItems"))

        if (products === null || products.length <= 0) {
            $(".total-price-box").remove();
            $('#basket-container').parent().parent().addClass("col-sm-12");
            let html = `
                                 <div class="col-sm-12 py-5">
                                     <div style="width:100%;display:flex;justify-content:center; align-items:center;flex-direction:column">
                                        <svg width="46" height="46" viewBox="0 0 46 46" fill="none" xmlns="http://www.w3.org/2000/svg"><path d="M18.438 43.375a3.062 3.062 0 1 0 0-6.125 3.062 3.062 0 0 0 0 6.125z" fill="url(#a)"></path><path d="M33.063 43.375a3.062 3.062 0 1 0 0-6.125 3.062 3.062 0 0 0 0 6.125z" fill="url(#b)"></path><path d="M12.47 10.895l-.35 4.287a1.388 1.388 0 0 0 1.4 1.505h26.793c.734 0 1.347-.56 1.4-1.295.227-3.097-2.136-5.617-5.233-5.617H14.973a4.772 4.772 0 0 0-1.068-2.118 4.654 4.654 0 0 0-3.36-1.47H7.5c-.718 0-1.313.595-1.313 1.313 0 .717.595 1.313 1.313 1.313h3.045c.543 0 1.05.227 1.418.612.367.402.542.927.507 1.47z" fill="url(#c)"></path><path d="M39.893 19.313H13.048c-.735 0-1.33.56-1.4 1.277l-.63 7.613c-.245 2.992 2.1 5.547 5.092 5.547h19.46c2.625 0 4.935-2.152 5.128-4.777l.577-8.173a1.37 1.37 0 0 0-1.382-1.488z" fill="url(#d)"></path><path d="M3.5 3.5h3.045A3.238 3.238 0 0 1 9.765 7L8.312 24.43c-.244 2.852 2.013 5.303 4.883 5.303h18.637c2.52 0 4.725-2.066 4.918-4.568l.945-13.125c.21-2.905-1.995-5.268-4.917-5.268H10.185M28.438 38.5a2.188 2.188 0 1 0 0-4.375 2.188 2.188 0 0 0 0 4.375zM14.438 38.5a2.188 2.188 0 1 0 0-4.375 2.188 2.188 0 0 0 0 4.375zM15.75 14h21" stroke="#596873" stroke-width="1.5" stroke-miterlimit="10" stroke-linecap="round" stroke-linejoin="round"></path><defs><linearGradient id="a" x1="22" y1="36.5" x2="16.5" y2="44" gradientUnits="userSpaceOnUse"><stop stop-color="#2BDBF3"></stop><stop offset="1" stop-color="#FFE1B4" stop-opacity=".5"></stop></linearGradient><linearGradient id="b" x1="36.625" y1="36.5" x2="31.125" y2="44" gradientUnits="userSpaceOnUse"><stop stop-color="#2BDBF3"></stop><stop offset="1" stop-color="#FFE1B4" stop-opacity=".5"></stop></linearGradient><linearGradient id="c" x1="27" y1="6" x2="24" y2="20" gradientUnits="userSpaceOnUse"><stop stop-color="#2BDBF3"></stop><stop offset="1" stop-color="#FFE1B4" stop-opacity=".5"></stop></linearGradient><linearGradient id="d" x1="30.5" y1="-.5" x2="14.5" y2="39.5" gradientUnits="userSpaceOnUse"><stop stop-color="#2BDBF3"></stop><stop offset="1" stop-color="#FFE1B4" stop-opacity=".5"></stop></linearGradient></defs></svg>
                                        <h4 class="mt-3">Səbətinizdə məhsul yoxdur !</h4>
                                        <a class="go-back" href="/Home/Index">Ana səhifəyə</a>
                                     </div>
                                 </div>
                                `
            $('#basket-container').append(html);
            return;
        }
        let ids = [];
        for (var i = 0; i < products.length; i++) {
            let element = products[i];
            ids.push(element.id)
        }
        $.ajax({
            url: "/CustomerOperation/GetProduct",
            type: "Post",
            data: {
                likedProductIds: ids
            },
            success: function (res) {
                const container = $('#basket-container');
                let html = "";
                container.html("");
                res.data.forEach(product => {
                    
                    html = html + `
                                     <div class="col-sm-12 mb-3">
                                    <div class="basket-card" style="justify-content: space-between;">
                                        <div class="card-image">
                                            <img src="/AdminPanelProjectFolderNameImages/ProductImage/${product.images[0].imageName}" alt="">
                                        </div>
                                        <div class="product-info" style="width: 700px;">
                                            <p>${product.brand.name} ${product.name}</p>
                                            <span>${product.price} <img src="assets/img/price_logo_green.svg" alt=""></span>
                                            <div class="offer">
                                                <div class="offer-box" >
                                                    <span>Faizsiz kredit</span>
                                                </div>
                                                <div class="product-detail">
                                                    <div>
                                                        <span>Rəng</span>
                                                        <div class="color">

                                                        </div>
                                                    </div>
                                                    <div>
                                                        <span></span>
                                                        <span>128GB</span>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="close-box">
                                            <div class="close">
                                                <button class="remove-product" data-id="${product.id}">
                                                    <img src="assets/img/x.svg" alt="">
                                                </button>
                                            </div>
                                            <div class="product-count">
                                                <button class="minus-btn">-</button>
                                                <div class="count">
                                                    <span>${getCount(products, product.id)}</span>
                                                </div>
                                                <button class="plus-btn">+</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                `
                })
                container.append(html)
            }
        });
    }

    function getCount(products, id) {
        let count = 0;
        for (var i = 0; i < products.length; i++) {
            let element = products[i];
            if (element.id === id) {
                count = element.count;
                break;
            }
        }
        return count;
    }

    $(document).on('click', '.remove-product', function () {
        debugger;
        const productId = $(this).data('id');
        let basketItems = JSON.parse(localStorage.getItem("basketItems"));
        for (var i = 0; i < basketItems.length; i++) {
            let element = basketItems[i];
            if (element.id === productId) {
                console.log("is remve", element)
                let newBasket=basketItems.filter(s => s !== element);
                localStorage.setItem("basketItems", JSON.stringify(newBasket));
                break;
            }
        }
        window.location.reload();
    });
})