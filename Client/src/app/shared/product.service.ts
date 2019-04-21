import { Injectable } from '@angular/core';
import { Product } from './product.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

 
  formData  : Product;
  list : Product[];
 readonly rootURL ="http://localhost:54277/api"
 
 constructor(private http : HttpClient) { }

 postProducts(formData : Product){
   console.log(formData);
  return this.http.post(this.rootURL+'/Products',formData);
  }

  refreshList(){
    this.http.get(this.rootURL + '/Products')
    .toPromise().then(res => this.list = res as Product[]);
  }
  putProducts(formData : Product){
    return this.http.put(this.rootURL+'/Products/'+ formData.Product_ID,formData);
    }

    deleteProducts(id : number){
      return this.http.delete(this.rootURL+'/Products/'+id);
     }

}

