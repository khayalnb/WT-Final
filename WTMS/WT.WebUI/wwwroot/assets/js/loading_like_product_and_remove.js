$(document).ready(function () {
    load();
    function load() {
        const ids = JSON.parse(localStorage.getItem("likedProductIds"))
        if (ids === null || ids.length <= 0) {
            let html = `
                                 <div class="col-sm-12 py-5">
                                     <div style="width:100%;display:flex;justify-content:center; align-items:center;flex-direction:column">
                                        <img src="/assets/img/likeHeart.png"/>
                                        <h4 class="mt-3">Bəyənilənlər siyahsı boşdur !</h4>
                                        <a class="go-back" href="/Home/Index">Ana səhifəyə</a>
                                     </div>
                                 </div>
                                `
            $('.like-container').append(html);
            return;
        }
        $.ajax({
            url: "/CustomerOperation/GetProduct",
            type: "Post",
            data: {
                likedProductIds: ids
            },
            success: function (res) {
                const container = $('.like-container');
                let html = "";
                container.html("");
                res.data.forEach(product => {
                    html = html + `
                                     <div class="col-sm-12 mb-3">
                                        <div class="like-card">
                                            <div class="product-image">
                                                <img src="/AdminPanelProjectFolderNameImages/ProductImage/${product.images[0].imageName}" alt="">
                                            </div>
                                            <div class="product-detail">
                                                <div class="category-name">
                                                    <span>${product.brand.name}</span>
                                                    <span>${product.name}</span>
                                                </div>
                                                <div class="info-product">
                                                    <div style="display:flex; flex-direction:column; margin-right:3rem">
                                                        <span>Endirim məbləgi</span>
                                                       <span style="margin-top:5px;">${product.disCount} AZN</span>
                                                    </div>
                                                    <div>
                                                        <span>Çatdırılma</span>
                                                        <span>${product.isFreeDelivery}</span>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="offer">
                                                <div class="offer-box">
                                                    <span>Faizsiz kredit</span>
                                                </div>
                                            </div>
                                            <div class="basket-price">
                                                <div>
                                                    <span>${product.price} <img src="/assets/img/price_logo_green.svg" alt=""></span>
                                                    <button data-heart-id=${product.id} class="remove-product"><img src="/assets/img/x.svg" alt=""></button>
                                                </div>
                                                <button >
                                                    <img src="/assets/img/basket.svg" alt="">
                                                    Səbətə əlavə et
                                                </button>
                                            </div>
                                        </div>
                                    </div>
                                `
                })
                container.append(html)
            }
        });
    }


    $(document).on('click', '.remove-product', function () {
        const productId = $(this).data('heart-id');
        let likedProductIds = JSON.parse(localStorage.getItem("likedProductIds"));
        likedProductIds = likedProductIds.filter(id => id !== productId);
        localStorage.setItem("likedProductIds", JSON.stringify(likedProductIds));
        window.location.reload();
    });
})