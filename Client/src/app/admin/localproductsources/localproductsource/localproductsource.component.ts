import { Component, OnInit } from '@angular/core';
import { LocalproductsourceService } from 'src/app/shared/localproductsource.service';
import { ToastrService } from 'ngx-toastr';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-localproductsource',
  templateUrl: './localproductsource.component.html',
  styleUrls: ['./localproductsource.component.css']
})
export class LocalproductsourceComponent implements OnInit {

  constructor(private service: LocalproductsourceService,
    private toastr: ToastrService){ }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form != null)
      form.resetForm();
    this.service.formData = {
      Local_Product_Source_ID: null,
      Seeding_Cost: null,
      Ploughing_Cost: null,
      Watering_Cost: null,
      Labour_Cost: null,
      Processing_Cost: null,
      Total_Production_Cost: null

    }
  }
  onSubmit(form: NgForm) {
    if (form.value.Local_Product_Source_ID == null)
      this.insertRecord(form);
   else
      this.updateRecord(form);
  }

  insertRecord(form: NgForm) {
    this.service.postLocalProductSource(form.value).subscribe(res => {
      this.toastr.success('Inserted successfully', 'lps. Register');
      this.resetForm(form);
      this.service.refreshList();
    });
  }

  updateRecord(form: NgForm) {
    this.service.putLocalProductSource(form.value).subscribe(res => {
      this.toastr.info('Updated successfully', 'lps. Register');
      this.resetForm(form);
      this.service.refreshList();
    }); 
  }
}
