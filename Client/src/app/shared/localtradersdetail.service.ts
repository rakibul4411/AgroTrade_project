import { Injectable } from '@angular/core';
import { Localtradersdetail } from './localtradersdetail.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class LocaltradersdetailService {
  formData  : Localtradersdetail;
  list : Localtradersdetail[];
 readonly rootURL ="http://localhost:54277/api"
 
 constructor(private http : HttpClient) { }

 postLocalTradersDetails(formData : Localtradersdetail){
   console.log(formData);
  return this.http.post(this.rootURL+'/LocalTradersDetails',formData);
  }

  refreshList(){
    this.http.get(this.rootURL + '/LocalTradersDetails')
    .toPromise().then(res => this.list = res as Localtradersdetail[]);
  }
  putLocalTradersDetails(formData : Localtradersdetail){
    return this.http.put(this.rootURL+'/LocalTradersDetails/'+ formData.Local_Trader_ID,formData);
    }

    deleteLocalTradersDetails(id : number){
      return this.http.delete(this.rootURL+'/LocalTradersDetails/'+id);
     }

}
