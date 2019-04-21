import { Component, OnInit } from '@angular/core';
//import { MarketService } from '../../shared/market.service';
import { ToastrService } from 'ngx-toastr';
import { NgForm } from '@angular/forms';
import { MarketService } from 'src/app/shared/market.service';

@Component({
  selector: 'app-market',
  templateUrl: './market.component.html',
  styleUrls: ['./market.component.css']
})
export class MarketComponent implements OnInit {
  constructor(private service: MarketService,
    private toastr: ToastrService){ }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form != null)
      form.resetForm();
    this.service.formData = {
      Market_ID: null,
      Market_Name: '',
      Market_Address: '',
      Post_Code: '',
      District:'',
      Country_Name:''
    }
  }
  onSubmit(form: NgForm) {
    if (form.value.Market_ID == null)
      this.insertRecord(form);
   else
      this.updateRecord(form);
  }

  insertRecord(form: NgForm) {
    this.service.postMarketList(form.value).subscribe(res => {
      this.toastr.success('Inserted successfully', 'MAR. Register');
      this.resetForm(form);
      this.service.refreshList();
    });
  }

  updateRecord(form: NgForm) {
    this.service.putMarketList(form.value).subscribe(res => {
      this.toastr.info('Updated successfully', 'FAR. Register');
      this.resetForm(form);
      this.service.refreshList();
    }); 
  }
}
