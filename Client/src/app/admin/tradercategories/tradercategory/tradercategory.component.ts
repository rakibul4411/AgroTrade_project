import { Component, OnInit } from '@angular/core';
//import { TradercategoryService } from '../../shared/tradercategory.service';
import { ToastrService } from 'ngx-toastr';
import { NgForm } from '@angular/forms';
import { TradercategoryService } from 'src/app/shared/tradercategory.service';

@Component({
  selector: 'app-tradercategory',
  templateUrl: './tradercategory.component.html',
  styleUrls: ['./tradercategory.component.css']
})
export class TradercategoryComponent implements OnInit {

  constructor(private service: TradercategoryService,
    private toastr: ToastrService){ }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form != null)
      form.resetForm();
    this.service.formData = {
      Trader_Category_ID: null,
      Trader_Category_Name: ''
    }
  }
  onSubmit(form: NgForm) {
    if (form.value.Trader_Category_ID == null)
      this.insertRecord(form);
   else
      this.updateRecord(form);
  }

  insertRecord(form: NgForm) {
    this.service.postTraderCategory(form.value).subscribe(res => { 
        
      this.resetForm(form);
      this.service.refreshList();
      this.toastr.success('Inserted successfully', 'TCN. Register');
    });
  }

  updateRecord(form: NgForm) {
    this.service.putTraderCategory(form.value).subscribe(res => {
      this.toastr.info('Updated successfully', 'TCN. Register');
      this.resetForm(form);
      this.service.refreshList();
    }); 
  }
}
