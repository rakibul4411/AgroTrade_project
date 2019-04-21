import { Component, OnInit } from '@angular/core';
//import { FarmerService } from '../../shared/farmer.service';
//import { Farmer } from '../../shared/farmer.model';
import { ToastrService } from 'ngx-toastr';
import { FarmerService } from 'src/app/shared/farmer.service';
import { Farmer } from 'src/app/shared/farmer.model';


@Component({
  selector: 'app-farmer-list',
  templateUrl: './farmer-list.component.html',
  styleUrls: ['./farmer-list.component.css']
})
export class FarmerListComponent implements OnInit {

  constructor(private service: FarmerService,
    private toastr: ToastrService) { }

  ngOnInit() {
    this.service.refreshList();
  }
  populateForm(far: Farmer) { 
    this.service.formData = Object.assign({}, far);
  }
  onDelete(id: number) {
    if (confirm('Are you sure to delete this record?')) {
      this.service.deleteFarmerList(id).subscribe(res => {
        this.service.refreshList();
        this.toastr.warning('Deleted successfully', 'FAR. Register');
      });
    }
  }

}
