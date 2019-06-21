
const axios = require('axios'),
      jsdom = require('jsdom'),
      { JSDOM } = jsdom,
      url = 'https://www.hurriyet.com.tr';
	  axios.get(url)
  .then (response => {
    getNodes(response.data);
  })
  .catch(error => {
    console.error(error);
  })
  
  const getNodes = html => {
  const data = [], // Boş bir array oluşturuyoruz
  dom = new JSDOM(html), // Yeni bir JSDOM instanceı alıyoruz
  news = dom.window.document.querySelectorAll('.flash-four-widget-css a'); // dom'dan gelen nodelar arasında gezerek o modülün içerisindeki a etiketlerini çekiyorum.
  news.forEach(item => { // daha sonra bu seçtiğim öğelerde dönüyorum
    data.push({ // yukarıdaki boş arraye her elemanın title ve href özelliklerini atıyorum
      title: item.getAttribute('title'),
      link: item.getAttribute('href')
    })
  });
  console.log(data); // Arrayin son halini yazdırıyorum. Burada elinize gelen data ile ne yapacağınız size kalmış :)
}