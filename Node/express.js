 var express = require('express');
 var app = express();
 var fs = require('fs');
 
 app.get('/listele', function(req,res){
	 //res.send('kullanıcıları listeleyeceğiz');
	 fs.readFile('user.json', 'utf8', function(err,data){
		console.log(data);
		res.end(data); 
	 });
	 	
 });
 
  app.get('/ekle', function(req,res){
	 //res.end('kullanıcı ekle');
	 var yeniKullanici = {
		 "user":{
			 "isim" : req.query.isim,
			 "sifre" : req.query.sifre,
			 "email" : req.query.email
		 }
	 };
	 
	 fs.readFile('user.json', 'utf8', function(err,data){
		 data=JSON.parse(data);
		 data[data.user.length] = yeniKullanici;
		 console.log(data);
		 res.end(JSON.stringify(data));
		 fs.writeFile('user.json',JSON.stringify(data),function(err){
			console.log('bir hata olustu');
		 });
	 });
	 
 });
 
  app.get('/sil', function(req,res){
	 //res.end('kullanıcı sil');
	 fs.readFile('user.json', 'utf8', function(err,data){
		 data=JSON.parse(data);
		 delete data[index];
		 console.log(data);
		 res.end(JSON.stringify(data));
		 fs.writeFile('user.json',JSON.stringify(data),function(err){
			console.log('bir hata olustu');
		 });
	 });
 });
 
 var server = app.listen(8000, function() {
	 console.log('sunucu çalışıyor');
 });
 
 