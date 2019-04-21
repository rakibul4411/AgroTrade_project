import { Component, OnInit } from '@angular/core';
//import { ProductcategoryService } from 'src/app/admin/shared/productcategory.service';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { ProductcategoryService } from 'src/app/shared/productcategory.service';

@Component({
  selector: 'app-productcategory',
  templateUrl: './productcategory.component.html',
  styleUrls: ['./productcategory.component.css']
})
export class ProductcategoryComponent implements OnInit {

  constructor(private service: ProductcategoryService,
    private toastr: ToastrService){ }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form != null)
      form.resetForm();
    this.service.formData = {
      Product_Category_ID: null,
      Product_Category_Name: ''
    }
  }
  onSubmit(form: NgForm) {
    if (form.value.Product_Category_ID == null)
      this.insertRecord(form);
   else
      this.updateRecord(form);
  }

  insertRecord(form: NgForm) {
    this.service.postProductCategory(form.value).subscribe(res => {
      this.toastr.success('Inserted successfully', 'FAR. Register');
      this.resetForm(form);
      this.service.refreshList();
    });
  }

  updateRecord(form: NgForm) {
    this.service.putProductCategory(form.value).subscribe(res => {
      this.toastr.info('Updated successfully', 'FAR. Register');
      this.resetForm(form);
      this.service.refreshList();
    }); 
  }
}
