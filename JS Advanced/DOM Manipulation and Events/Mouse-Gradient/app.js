function attachGradientEvents() {
    let hoverElement = document.getElementById('gradient');
    let resultElement = document.getElementById('result');
    hoverElement.addEventListener('mousemove', onMouseoverHandler);
    hoverElement.addEventListener('mouseout', onMouseOutHandler);

    function onMouseoverHandler(e){
        let currentPlace = e.offsetX;
        let hover = e.target.clientWidth - 1;
        let percentage = (currentPlace / hover) * 100;
        resultElement.textContent = `${Math.floor(percentage)}%`;
    };

    function onMouseOutHandler(){
        resultElement.textContent = '';
    }
}