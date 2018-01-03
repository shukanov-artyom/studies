
const download = require('download');
const jsdom = require('jsdom');
const { JSDOM } = jsdom;

var url = 'https://stackoverflow.com/questions/7372972/how-do-i-parse-a-html-page-with-node-js';
download(url).then(data => {
    const scrapped = scrapHtml(data.toString());
    console.log(scrapped);
});

function fits(text) {
    var forbiddenWords = [ 'http' ];
    forbiddenWords.forEach(function(word) {
            if (text.indexOf(word) !== -1) {
                return false;
            }
        });
    return true;
}

function scrapHtml(html) {
    const tagsToExtract = ['p', 'h1', 'h2', 'h3'];
    var result = "";
    const dom = new JSDOM(html);
    tagsToExtract.forEach(function(tag){
        const elements = 
            dom.window.document.querySelectorAll(tag);
        for (var key in elements) {
            var text = elements[key].textContent;
            if (text && fits(text)) {
                result = result + '\r\n' + text;
            }
        }
    });
    return result;
}