import { Component, OnInit } from '@angular/core';
//import { ProductunitService } from 'src/app/admin/shared/productunit.service';
import { ToastrService } from 'ngx-toastr';
import { NgForm } from '@angular/forms';
import { ProductunitService } from 'src/app/shared/productunit.service';

@Component({
  selector: 'app-productunit',
  templateUrl: './productunit.component.html',
  styleUrls: ['./productunit.component.css']
})
export class ProductunitComponent implements OnInit {
  constructor(private service: ProductunitService,
    private toastr: ToastrService){ }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form != null)
      form.resetForm();
    this.service.formData = {
      Product_Unit_ID: null,
      Product_Unit_Quantity: null
    }
  }
  onSubmit(form: NgForm) {
    if (form.value.Product_Unit_ID == null)
      this.insertRecord(form);
   else
      this.updateRecord(form);
  }

  insertRecord(form: NgForm) {
    this.service.postProductUnit(form.value).subscribe(res => {
      this.toastr.success('Inserted successfully', 'PU. Register');
      this.resetForm(form);
      this.service.refreshList();
    });
  }

  updateRecord(form: NgForm) {
    this.service.putProductUnit(form.value).subscribe(res => {
      this.toastr.info('Updated successfully', 'PU. Register');
      this.resetForm(form);
      this.service.refreshList();
    }); 
  }
}
