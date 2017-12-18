const fs = require('fs');
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
    for (var word in forbiddenWords) {
        if (text.indexOf(word) !== -1) {
            return false;
        }
    }
    return true;
}

function scrapHtml(html) {
    const tags = ['p', 'h1', 'h2', 'h3'];
    var result = "";
    const dom = new JSDOM(html);
    for (var tag in tags) {
        const elements = dom.window.document.querySelectorAll(tags[tag]);
        for (var key in elements) {
            var text = elements[key].textContent;
            if (text && fits(text)) {
                result = result + '\r\n' + text;
            }
        }
    }
    return result;
}