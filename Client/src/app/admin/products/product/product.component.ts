import { Component, OnInit } from '@angular/core';
import { ProductService } from 'src/app/shared/product.service';
import { ToastrService } from 'ngx-toastr';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  constructor(private service: ProductService,
    private toastr: ToastrService){ }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form != null)
      form.resetForm();
    this.service.formData = {
      Product_ID: null,
      Product_Name: '',
      Details: '',
      Product_Source: ''
    }
  }
  onSubmit(form: NgForm) {
    if (form.value.Product_ID == null)
      this.insertRecord(form);
   else
      this.updateRecord(form);
  }

  insertRecord(form: NgForm) {
    this.service.postProducts(form.value).subscribe(res => {
      this.toastr.success('Inserted successfully', 'P. Register');
      this.resetForm(form);
      this.service.refreshList();
    });
  }

  updateRecord(form: NgForm) {
    this.service.putProducts(form.value).subscribe(res => {
      this.toastr.info('Updated successfully', 'P. Register');
      this.resetForm(form);
      this.service.refreshList();
    }); 
  }
}
