import { Injectable } from '@angular/core';
import { Retailersdetail } from './retailersdetail.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class RetailersdetailService {

  formData  : Retailersdetail;
  list : Retailersdetail[];
 readonly rootURL ="http://localhost:54277/api"
 
 constructor(private http : HttpClient) { }

 postRetailersDetails(formData : Retailersdetail){
   console.log(formData);
  return this.http.post(this.rootURL+'/RetailersDetails',formData);
  }

  refreshList(){
    this.http.get(this.rootURL + '/RetailersDetails')
    .toPromise().then(res => this.list = res as Retailersdetail[]);
  }
  putRetailersDetails(formData : Retailersdetail){
    return this.http.put(this.rootURL+'/RetailersDetails/'+ formData.Retailer_ID,formData);
    }

    deleteRetailersDetails(id : number){
      return this.http.delete(this.rootURL+'/RetailersDetails/'+id);
     }

}
