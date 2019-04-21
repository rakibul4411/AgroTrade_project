import { Injectable } from '@angular/core';
import { Tradercategory } from './tradercategory.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class TradercategoryService {

  formData  : Tradercategory;
  list : Tradercategory[];
 readonly rootURL ="http://localhost:54277/api"
 
 constructor(private http : HttpClient) { }

 postTraderCategory(formData : Tradercategory){
   console.log(formData);
  return this.http.post(this.rootURL+'/TraderCategory',formData);
  }

  refreshList(){
    this.http.get(this.rootURL + '/TraderCategory')
    .toPromise().then(res => this.list = res as Tradercategory[]);
  }
  putTraderCategory(formData : Tradercategory){
    return this.http.put(this.rootURL+'/TraderCategory/'+ formData.Trader_Category_ID, formData);
    }

    deleteTraderCategory(id : number){
      return this.http.delete(this.rootURL+'/TraderCategory/'+id);
     }

}