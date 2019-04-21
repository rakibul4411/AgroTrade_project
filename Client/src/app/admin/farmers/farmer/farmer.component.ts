import { Component, OnInit } from '@angular/core';
//import { FarmerService } from 'src/app/admin/shared/farmer.service';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { FarmerService } from 'src/app/shared/farmer.service';

@Component({
  selector: 'app-farmer',
  templateUrl: './farmer.component.html',
  styleUrls: ['./farmer.component.css']
})
export class FarmerComponent implements OnInit {

  constructor(private service: FarmerService,
    private toastr: ToastrService){ }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form != null)
      form.resetForm();
    this.service.formData = {
      Farmer_ID: null,
      Farmer_Name: '',
      Address: '',
      Phone: ''
    }
  }
  onSubmit(form: NgForm) {
    if (form.value.Farmer_ID == null)
      this.insertRecord(form);
   else
      this.updateRecord(form);
  }

  insertRecord(form: NgForm) {
    this.service.postFarmerList(form.value).subscribe(res => {
      this.toastr.success('Inserted successfully', 'FAR. Register');
      this.resetForm(form);
      this.service.refreshList();
    });
  }

  updateRecord(form: NgForm) {
    this.service.putFarmerList(form.value).subscribe(res => {
      this.toastr.info('Updated successfully', 'FAR. Register');
      this.resetForm(form);
      this.service.refreshList();
    }); 
  }
}
