let password = document.getElementById("password_input");
let btn = document.getElementById("show-hide-btn");

function inputSecretOrvisible() {
    btn.addEventListener('click', function () {
        if (password.type == "password" && btn.getAttribute('src')=="assets/img/login/eye.svg") {
            password.type = "text"
            btn.src="assets/img/login/eye-slash.svg";
            
        } else {
            password.type = "password"
            btn.src="assets/img/login/eye.svg";
        
        }
    });
};
inputSecretOrvisible();


let submitBtn=document.querySelector('.submit-btn-box > button');
let phoneInput=document.getElementById('phone_input');
submitBtn.addEventListener('click',async ()=>{
    validation(phoneInput,"Nömrə boş ola bilməz !");
    validation(password,"Şifrə boş ola bilməz !");


}) 
phoneInput.addEventListener('keyup',async ()=>{
    validation(phoneInput,"Nömrə boş ola bilməz !");
})
password.addEventListener('keyup',async ()=>{
    validation(password,"Şifrə boş ola bilməz !");
})
function validation(userInfo, message) {
    if (userInfo.value == "") {
        userInfo.style.border = "1px solid red"
        userInfo.placeholder = message;
        userInfo.classList.add("active");
    } else {
        userInfo.style.border = "1px solid green"
    }
}