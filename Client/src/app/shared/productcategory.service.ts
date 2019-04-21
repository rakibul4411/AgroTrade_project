import { Injectable } from '@angular/core';
import { Productcategory } from './productcategory.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ProductcategoryService {

  formData  : Productcategory;
  list : Productcategory[];
 readonly rootURL ="http://localhost:54277/api"
 
 constructor(private http : HttpClient) { }

 postProductCategory(formData : Productcategory){
   console.log(formData);
  return this.http.post(this.rootURL+'/ProductCategory',formData);
  }

  refreshList(){
    this.http.get(this.rootURL + '/ProductCategory')
    .toPromise().then(res => this.list = res as Productcategory[]);
  }
  putProductCategory(formData : Productcategory){
    return this.http.put(this.rootURL+'/ProductCategory/'+ formData.Product_Category_ID,formData);
    }

    deleteProductCategory(id : number){
      return this.http.delete(this.rootURL+'/ProductCategory/'+id);
     }

}
