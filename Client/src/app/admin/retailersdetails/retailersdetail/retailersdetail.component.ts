import { Component, OnInit } from '@angular/core';
import { RetailersdetailService } from 'src/app/shared/retailersdetail.service';
import { ToastrService } from 'ngx-toastr';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-retailersdetail',
  templateUrl: './retailersdetail.component.html',
  styleUrls: ['./retailersdetail.component.css']
})
export class RetailersdetailComponent implements OnInit {

  constructor(private service: RetailersdetailService,
    private toastr: ToastrService){ }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form != null)
      form.resetForm();
    this.service.formData = {
     Retailer_ID: null,
     Retailer_Name: '',
     Retailers_Buying_Price: null,
     Transportation_Cost: null,
     Total_Cost_PerUnit: null,
     Retailer_Selling_Price: null
    }
  }
  onSubmit(form: NgForm) {
    if (form.value.Retailer_ID == null)
      this.insertRecord(form);
   else
      this.updateRecord(form);
  }

  insertRecord(form: NgForm) {
    this.service.postRetailersDetails(form.value).subscribe(res => {
      this.toastr.success('Inserted successfully', 'rd. Register');
      this.resetForm(form);
      this.service.refreshList();
    });
  }

  updateRecord(form: NgForm) {
    this.service.putRetailersDetails(form.value).subscribe(res => {
      this.toastr.info('Updated successfully', 'rd. Register');
      this.resetForm(form);
      this.service.refreshList();
    }); 
  }
}
