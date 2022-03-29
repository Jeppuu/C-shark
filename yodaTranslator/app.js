function toYoda() {
//fetch('https://api.funtranslations.com/translate/yoda.json')
fetch('https://api.funtranslations.com/translate/yoda.json')
  .then(response => response.json())
  .then(data => console.log(data));
}
