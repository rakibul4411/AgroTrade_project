import { Injectable } from '@angular/core';
import { Productunit } from './productunit.model';
//import { HttpClient } from 'selenium-webdriver/http';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ProductunitService {
  formData  : Productunit;
  list : Productunit[];
 readonly rootURL ="http://localhost:54277/api"
 
 constructor(private http : HttpClient) { }

 postProductUnit(formData : Productunit){
   console.log(formData);
  return this.http.post(this.rootURL+'/ProductUnit',formData);
  }

  refreshList(){
    this.http.get(this.rootURL + '/ProductUnit')
    .toPromise().then(res => this.list = res as Productunit[]);
  }
  putProductUnit(formData : Productunit){
    return this.http.put(this.rootURL+'/ProductUnit/'+ formData.Product_Unit_ID,formData);
    }

    deleteProductUnit(id : number){
      return this.http.delete(this.rootURL+'/ProductUnit/'+id);
     }

}
