let mainImageBox=document.getElementById("main-img");
let imgList=document.querySelectorAll(".img-item");

imgList.forEach(item=>{
    item.addEventListener("click",function(e){
        imgList.forEach(classAct => {
            classAct.classList.remove("active");
        });
        e.preventDefault();
        this.classList.add("active");
        mainImageBox.src=item.children[0].src;
    })
})