import { Injectable } from '@angular/core';
import { Wholesaler } from './wholesaler.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class WholesalerService {

  formData  : Wholesaler;
  list : Wholesaler[];
 readonly rootURL ="http://localhost:54277/api"
 
 constructor(private http : HttpClient) { }

 postWholeSalers(formData : Wholesaler){
   console.log(formData);
  return this.http.post(this.rootURL+'/WholeSalers',formData);
  }

  refreshList(){
    this.http.get(this.rootURL + '/WholeSalers')
    .toPromise().then(res => this.list = res as Wholesaler[]);
  }
  putWholeSalers(formData : Wholesaler){
    return this.http.put(this.rootURL+'/WholeSalers/'+ formData.Whole_Saler_ID,formData);
    }

    deleteWholeSalers(id : number){
      return this.http.delete(this.rootURL+'/WholeSalers/'+id);
     }

}
