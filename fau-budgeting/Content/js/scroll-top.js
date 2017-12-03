function scrollFunction() {
    'use strict';
    if (document.body.scrollTop > 30 || document.documentElement.scrollTop > 30) {
        document.getElementById("myBtn").style.display = "block";
    } else {
        document.getElementById("myBtn").style.display = "none";
    }
}

// When the user scrolls down 20px from the top of the document, show the button
window.onscroll = function () {
    'use strict';
    scrollFunction();
};


// When the user clicks on the button, scroll to the top of the document
function topFunction() {
    'use strict';
    document.body.scrollTop = 0; // For Chrome, Safari and Opera 
    document.documentElement.scrollTop = 0; // For IE and Firefox
}

//HTML CODE
/*<!---Scroll to top-->
<button onclick="topFunction()" id="myBtn" title="Return to top"><i class="fa fa-arrow-up"></i></button>
<!---/. Scroll to top-->*/