import { Component, OnInit } from '@angular/core';
import { ImportedproductsourceService } from 'src/app/shared/importedproductsource.service';
import { ToastrService } from 'ngx-toastr';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-importedproductsource',
  templateUrl: './importedproductsource.component.html',
  styleUrls: ['./importedproductsource.component.css']
})
export class ImportedproductsourceComponent implements OnInit {

 
  constructor(private service: ImportedproductsourceService,
    private toastr: ToastrService){ }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form != null)
      form.resetForm();
    this.service.formData = {
      Imported_Product_Source_ID: null,
      Imported_Product_Buying_Cost:null,
        Shipment_Cost:null,
        Custom_Tax:null,
        Transportation_Cost:null,
         Storing_Cost:null,
         Total_Cost:null,
        Importers_WholeSale_Price:null
    }
  }
  onSubmit(form: NgForm) {
    if (form.value.Imported_Product_Source_ID == null)
      this.insertRecord(form);
   else
      this.updateRecord(form);
  }

  insertRecord(form: NgForm) {
    this.service.postImportedProductSource(form.value).subscribe(res => {
      this.toastr.success('Inserted successfully', 'IPS. Register');
      this.resetForm(form);
      this.service.refreshList();
    });
  }

  updateRecord(form: NgForm) {
    this.service.putImportedProductSource(form.value).subscribe(res => {
      this.toastr.info('Updated successfully', 'IPS. Register');
      this.resetForm(form);
      this.service.refreshList();
    }); 
  }
}

