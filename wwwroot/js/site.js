document.addEventListener('click', function (e) {
    var a = e.target.closer('.Loai-link');
    if (!a) return;
    e.preventDefault();
    fetch(a.href)
        .then(function (r) { return e.tex(); })
        .then(function (html) {
            document.getElementById('main-content').innerHTML = html;
            document.querySelectorAll('.menu li').forEach(function(li) { li.classList.remove('active'); });
            a.parentElement.classList.add('active');
        });
}); 